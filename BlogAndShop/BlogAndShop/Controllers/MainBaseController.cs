using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BlogAndShop.Classes;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogAndShop.Controllers
{
    public class MainBaseController : Controller
    {
        protected IActionResult MessagePage(string message)
        {
            return View("MessageShowPage", new MessageShowPageViewModel() { Message = message });
        }

        protected int? GetUserId()
        {
            if (User.Identity.IsAuthenticated) return Convert.ToInt32(User.Identity.Name);
            return null;
        }

        /// <summary>
        /// get error in model state as string[]
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        protected virtual string[] GetErrors(ModelStateDictionary modelState)
        {
            var values = modelState.Values;
            var errors = new List<string>();
            foreach (var tempErrors in values.Select(value => value.Errors))
            {
                errors.AddRange(tempErrors.Select(x => x.ErrorMessage));
            }
            return errors.ToArray();
        }

        protected virtual ApiJsonResult<T> ReturnJsonResult<T>(T data = default(T), string[] messages = null)
        {
            var result = new ApiJsonResult<T>
            {
                ok = true,
                data = data,
                description = messages,
                status_code = 200
            };
            return result;
        }
        protected virtual ApiJsonResult<T> ReturnErrorJsonResult<T>(string[] descriptions = null,
            HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            Response.StatusCode = (int)statusCode;
            var result = new ApiJsonResult<T>()
            {
                description = descriptions,
                status_code = (int)statusCode,
                ok = false,
                data = default(T)
            };
            return result;
        }
        protected virtual ApiJsonResult<T> ReturnErrorJsonResult<T>(string description = null,
            HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return ReturnErrorJsonResult<T>(new[] { description });
        }

    }
}