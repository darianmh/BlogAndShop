using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminIndexListing : ViewComponent
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<IViewComponentResult> InvokeAsync(ListPaginationModel paging, object items)
        {
            var type = items.GetType();
            var modelType = type.GetGenericArguments()[0];
            var result = GetShowModel(paging, (IEnumerable)items, modelType);
            return View(result);
        }

        #endregion
        #region Utilities
        private AdminShowListViewModel GetShowModel(ListPaginationModel paging, IEnumerable items, Type type)
        {
            var propertyList = GetPropertyList(type);
            var keys = GetPropertiesKey(propertyList);
            var values = GetPropertiesValue(items, propertyList);
            return new AdminShowListViewModel()
            {
                Values = values,
                AdminListPaginationModel = paging,
                Keys = keys,
                Controller = Request.RouteValues["Controller"]?.ToString()
            };
        }

        private Dictionary<string, List<string>> GetPropertiesValue(IEnumerable modelItems, List<AdminShowItemAttributeInfo> propertyList)
        {
            var result = new Dictionary<string, List<string>>();

            foreach (object item in modelItems)
            {
                var temp = new List<string>();
                foreach (var property in propertyList)
                {
                    var value = property.PropertyInfo.GetValue(item)?.ToString();
                    if (value?.Length > 30) value = string.Join(string.Empty, value.Take(70)) + "...";
                    temp.Add(value);
                }

                var id = item.GetType()?.GetProperty("Id")?.GetValue(item)?.ToString() ?? "";
                result.Add(id, temp);
            }

            return result;
        }

        private List<string> GetPropertiesKey(List<AdminShowItemAttributeInfo> propertyList)
        {
            var result = new List<string>();
            foreach (var property in propertyList)
            {
                var attr = property.PropertyInfo.GetCustomAttribute(typeof(DisplayAttribute));
                var name = attr == null ? property.PropertyInfo.Name : ((DisplayAttribute)attr).Name;
                result.Add(name);
            }
            return result;
        }

        private static List<AdminShowItemAttributeInfo> GetPropertyList(Type type)
        {
            var properties = type.GetProperties();
            var propertyList = new List<AdminShowItemAttributeInfo>();
            foreach (var property in properties)
            {
                var attrToShow = property.GetCustomAttribute(typeof(AdminShowItemAttribute));
                if (attrToShow == null) continue;
                var temp = new AdminShowItemAttributeInfo
                {
                    Order = ((AdminShowItemAttribute)attrToShow).Order,
                    PropertyInfo = property
                };
                propertyList.Add(temp);
            }

            propertyList = propertyList.OrderBy(x => x.Order).ToList();
            return propertyList;
        }

        #endregion
        #region Ctor

        #endregion




    }
}