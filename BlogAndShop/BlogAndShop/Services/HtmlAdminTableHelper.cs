using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BlogAndShop.Services
{
	public static class HtmlAdminTableHelper
	{


		#region Fields


		#endregion
		#region Methods

		/// <summary>
		/// دریافت اعضای کلاس مد نظر و نمایش نام آن ها به عنوان هدر جدول
		/// </summary>
		/// <returns></returns>
		public static HtmlString AdminTableHeader(this IHtmlHelper html, Type type)
		{
			var propertyList = GetPropertyList(type);
			var tableHeader = "";
			foreach (var property in propertyList)
			{
				var attr = property.PropertyInfo.GetCustomAttribute(typeof(DisplayAttribute));
				var name = string.Empty;
				if (attr == null) name = property.PropertyInfo.Name;
				else name = ((DisplayAttribute)attr).Name;
				var temp = $"<th class=\"text-gray-500 font-weight-normal fs--14\">{name}</th>";
				tableHeader += temp;
			}

			tableHeader += $"<th class=\"text-gray-500 font-weight-normal fs--14\">&nbsp;</th>";
			return new HtmlString(tableHeader);
		}
		/// <summary>
		/// تبدیل کلاس به موارد جدول
		/// </summary>
		/// <param name="html"></param>
		/// <param name="type"></param>
		/// <param name="modelItems"></param>
		/// <param name="media"></param>
		/// <returns></returns>
		public static HtmlString AdminTableItems(this IHtmlHelper html, Type type, object modelItems, string controller)
		{
			var propertyList = GetPropertyList(type);
			var tableItems = string.Empty;
			foreach (object item in (IEnumerable)modelItems)
			{
				var itemTemplate = $@"
										<!-- Item -->
										<tr>";


				foreach (var property in propertyList)
				{
					var attrToShow = property.PropertyInfo.GetCustomAttribute(typeof(AdminShowItemAttribute));
					if (attrToShow == null) continue;
					var value = property.PropertyInfo.GetValue(item)?.ToString();
					if (value?.Length > 30) value = string.Join(string.Empty, value.Take(70)) + "...";
					var temp = @$"<!-- Item -->
						<td>
						{value}
						</td>";
					itemTemplate += temp;
				}

				itemTemplate += $@"<!-- options -->
											<td class='text-align-end'>

												<div class='clearfix'>
													<!-- using .dropdown, autowidth not working -->

													<a href='#' class='btn btn-sm btn-light rounded-circle' data-toggle='dropdown' aria-expanded='false' aria-haspopup='true'>
														<span class='group-icon'>
															<i class='fi fi-dots-vertical-full'></i>
															<i class='fi fi-close'></i>
														</span>
													</a>

													<div class='dropdown-menu dropdown-menu-clean dropdown-click-ignore max-w-220'>

														<div class='scrollable-vertical max-h-50vh'>

															<a class='dropdown-item text-truncate' href='/{controller}/Details/{type.GetProperty("Id")?.GetValue(item)}'>
																<i class='fi fi-info'></i>
																Details
															</a>
															<a class='dropdown-item text-truncate' href='/{controller}/Edit/{type.GetProperty("Id")?.GetValue(item)}'>
																<i class='fi fi-pencil'></i>
																Edit
															</a>
															<!--

							The request is sent by ajax to data-href='...'
							To change to regular submit, change:
								data-ajax-confirm-mode='regular' 	(or simply remove this param)

						-->
															<a href='#'
															   class='dropdown-item text-truncate js-ajax-confirm'
															   data-href='/{controller}/Delete/{type.GetProperty("Id")?.GetValue(item)}'
															   data-ajax-confirm-method='GET'
															   data-ajax-confirm-mode='ajax'
															   data-ajax-confirm-size='modal-md'
															   data-ajax-confirm-centered='false'
															   data-ajax-confirm-callback-function=''
															   data-ajax-confirm-title='لطفا تایید کنید'
															   data-ajax-confirm-body='آیا از حذف این مورد اطمینان دارید؟'
															   data-ajax-confirm-btn-yes-text='تایید'
															   data-ajax-confirm-btn-yes-class='btn-sm btn-danger'
															   data-ajax-confirm-btn-yes-icon='fi fi-check'
															   data-ajax-confirm-btn-no-text='لغو'
															   data-ajax-confirm-btn-no-class='btn-sm btn-light'
															   data-ajax-confirm-btn-no-icon='fi fi-close'>
																<i class='fi fi-thrash text-danger'></i>
																حذف!
															</a>



														</div>

													</div>

												</div>

											</td>

										</tr>
										<!-- /Item -->
";
				tableItems += itemTemplate;
			}

			return new HtmlString(tableItems);
		}

		#endregion
		#region Utilities

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
