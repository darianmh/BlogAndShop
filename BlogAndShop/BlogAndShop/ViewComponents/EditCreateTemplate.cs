using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Classes;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using BlogAndShop.Services.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnumListAttribute = BlogAndShop.Data.Classes.EnumListAttribute;
using HtmlEditAttribute = BlogAndShop.Data.Classes.HtmlEditAttribute;

namespace BlogAndShop.ViewComponents
{
    public class EditCreateTemplate : ViewComponent
    {
        #region Fields



        #endregion
        #region Methods

        /// <summary>
        /// سازنده قالب برای صفحه ویرایش و ساخت
        /// </summary>
        /// <typeparam name="T">مدل موجود در صفحه</typeparam>
        /// <param name="model"></param>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(object model, HttpContext httpContext)
        {
            var db = (ApplicationDbContext)httpContext.RequestServices.GetService(typeof(ApplicationDbContext));
            var properties = GetProperties(model);
            var baseProps = typeof(BaseEntity).GetProperties().Select(x => x.Name).ToList();
            var result = await CreateModel(properties, baseProps, model, db);
            return View(result);
        }

        #endregion
        #region Utilities

        private async Task<List<EditCreateTemplateViewModel>> CreateModel<T>(PropertyInfo[] properties,
            List<string> baseProps,
            T model, ApplicationDbContext db)
        {
            var result = new List<EditCreateTemplateViewModel>();
            foreach (var property in properties)
            {
                EditCreateTemplateType propType;
                if (baseProps?.Contains(property.Name) ?? false)
                {
                    propType = EditCreateTemplateType.Hidden;
                }
                else
                {
                    propType = GetInputType(property);
                }
                if (propType == EditCreateTemplateType.Ignore) continue;
                var name = GetDisplayName(property);
                var optionList = await GetOptionList(property, model, propType, db);
                var isRequired = CheckRequire(property);
                var typeName = GetTypeName(propType);
                var temp = new EditCreateTemplateViewModel
                {
                    ListForOptionList = optionList,
                    DisplayName = name,
                    Name = property.Name,
                    ObjectType = propType,
                    Value = property.GetValue(model),
                    IsRequired = isRequired,
                    TypeName = typeName
                };
                result.Add(temp);
            }

            return result;
        }

        private string GetTypeName(EditCreateTemplateType propType)
        {

            if (propType == EditCreateTemplateType.String)
                return "text";
            if (propType == EditCreateTemplateType.Date)
                return "date";
            if (propType == EditCreateTemplateType.Number || propType == EditCreateTemplateType.Decimal)
                return "number";
            return null;
        }

        private bool CheckRequire(PropertyInfo property)
        {
            var requireAttr = property.GetCustomAttribute(typeof(RequiredAttribute));
            return requireAttr != null;
        }

        /// <summary>
        /// create option list if needed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="model"></param>
        /// <param name="propType"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private async Task<List<SelectListItem>> GetOptionList<T>(PropertyInfo property, T model,
            EditCreateTemplateType propType, ApplicationDbContext db)
        {
            if (propType != EditCreateTemplateType.DbList && propType != EditCreateTemplateType.Enum && propType != EditCreateTemplateType.DbListMulti && propType != EditCreateTemplateType.EnumMulti)
                return null;
            if (propType == EditCreateTemplateType.Enum || propType == EditCreateTemplateType.EnumMulti)
                return GetEnumList(property, model);
            //type is db list
            return await GetDbOptionList(property, model, db);
        }

        /// <summary>
        /// find list in db and fill
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="model"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private async Task<List<SelectListItem>> GetDbOptionList<T>(PropertyInfo property, T model, ApplicationDbContext db)
        {
            var attr = property.GetCustomAttribute<DbOptionListAttribute>();
            if (attr == null) return null;
            var queryable = db.Set(attr.NavigationProperty);
            if (queryable == null) return null;
            MethodInfo method = attr.NavigationProperty.GetMethod(nameof(BaseEntity.GetSelectListItem));
            List<SelectListItem> list = new List<SelectListItem>();
            if (attr.AllowNull) list.Add(new SelectListItem("انتخاب کنید", null));
            list.AddRange(queryable.Select(x => (SelectListItem)method.Invoke(x, null)));
            return list;
        }

        /// <summary>
        /// get option list from enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        private List<SelectListItem> GetEnumList<T>(PropertyInfo property, T model)
        {
            var attr = property.GetCustomAttribute<EnumListAttribute>();
            if (attr == null) return null;
            var enumValues = attr.EnumType.GetEnumValues();
            var list = new List<SelectListItem>();
            foreach (var enumValue in enumValues)
            {
                var type = Convert.ChangeType(enumValue, attr.EnumType);
                var name = Enum.GetName(attr.EnumType, type);
                var val = ((int)type);
                var selected = val == ((int)(property.GetValue(model) ?? 0));
                list.Add(new SelectListItem(name, val.ToString(), selected));
            }

            return list;
        }

        /// <summary>
        /// get display name from display attr or prop name
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private string GetDisplayName(PropertyInfo property)
        {
            var displayAttr = (DisplayAttribute)property.GetCustomAttribute(typeof(DisplayAttribute));
            var name = displayAttr?.Name ?? property.Name;
            return name;
        }

        /// <summary>
        /// دریافت نوع ورودی ها
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static EditCreateTemplateType GetInputType(PropertyInfo property)
        {
            var isFile = CheckFileUpload(property);
            if (isFile)
                return EditCreateTemplateType.File;
            var isHidden = CheckHidden(property);
            if (isHidden)
                return EditCreateTemplateType.Hidden;
            var ignore = CheckIgnore(property);
            if (ignore)
                return EditCreateTemplateType.Ignore;
            var htmlEditor = CheckHtmlEditor(property);
            if (htmlEditor)
                return EditCreateTemplateType.HtmlEditor;
            var textArea = CheckTextAreaEditor(property);
            if (textArea)
                return EditCreateTemplateType.TextArea;
            var optionList = CheckDbList(property);
            if (optionList.Item1)
                if (optionList.Item2)
                    return EditCreateTemplateType.DbListMulti;
                else
                    return EditCreateTemplateType.DbList;
            var enumList = CheckEnumList(property);
            if (enumList.Item1)
                if (enumList.Item2)
                    return EditCreateTemplateType.EnumMulti;
                else
                    return EditCreateTemplateType.Enum;
            if (property.PropertyType == typeof(bool))
                return EditCreateTemplateType.Bool;
            if (property.PropertyType == typeof(string))
                return EditCreateTemplateType.String;
            if ((property.PropertyType == typeof(DateTime)) || (property.PropertyType == typeof(DateTime?)))
                return EditCreateTemplateType.Date;
            if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(double) || property.PropertyType == typeof(decimal?) || property.PropertyType == typeof(double?))
                return EditCreateTemplateType.Decimal;
            if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
                return EditCreateTemplateType.Number;
            return EditCreateTemplateType.String;
        }

        private static bool CheckHidden(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<HiddenAttribute>();
            return attr != null;
        }

        /// <summary>
        /// check model need to upload file
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static bool CheckFileUpload(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<FileUploadAttribute>();
            return attr != null;
        }

        private static bool CheckIgnore(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<IgnoreAttribute>();
            return attr != null;
        }

        /// <summary>
        /// if model value should fill from enum info
        /// </summary>
        /// <param name="property"></param>
        /// <returns>first bool is base and second bool is for multiple</returns>
        private static Tuple<bool, bool> CheckEnumList(PropertyInfo property)
        {
            var attr = (EnumListAttribute)property.GetCustomAttribute<Data.Classes.EnumListAttribute>();
            return new Tuple<bool, bool>(attr != null, attr?.Multiple ?? false);
        }

        /// <summary>
        /// if model value should fill from db info
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static Tuple<bool, bool> CheckDbList(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<DbOptionListAttribute>();
            return new Tuple<bool, bool>(attr != null, attr?.Multiple ?? false);
        }

        /// <summary>
        /// if model value should fill from db info
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static bool CheckTextAreaEditor(PropertyInfo property)
        {
            var attr = property.GetCustomAttribute<TextAreaAttribute>();
            return attr != null;
        }

        /// <summary>
        /// چک کردن اینکه آیا نوع ورودی اچ تی ام ال است یا نه
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private static bool CheckHtmlEditor(PropertyInfo property)
        {
            var htmlAttr = property.GetCustomAttribute<HtmlEditAttribute>();
            return htmlAttr != null;
        }

        private PropertyInfo[] GetProperties<T>(T model)
        {
            var type = model.GetType();
            var properties = type.GetProperties();
            return properties;
        }


        #endregion
        #region Ctor

        public EditCreateTemplate()
        {

        }
        #endregion

    }
}