﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace BlogAndShop.Classes
{
    public class LinkConstraint : IRouteConstraint
    {

        private readonly Dictionary<string, string> _linksList;
        /// <summary>
        /// check the inserted link =>
        /// if link exist in db, returns true
        /// else return false
        /// </summary>
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (httpContext == null) return false;
            //check the key exist
            if (values.TryGetValue(routeKey, out object rout))
            {
                //convert object key to string
                var routString = Convert.ToString(rout);
                if (!string.IsNullOrEmpty(routString))
                {
                    foreach (var link in _linksList)
                    {
                        if (routString.Contains(link.Key, StringComparison.OrdinalIgnoreCase))
                        {

                            httpContext.Items.TryAdd("LinkObject", link.Value);
                            return true;
                        }
                    }

                }
            }

            return false;
        }

        public LinkConstraint()
        {
            _linksList = new Dictionary<string, string>();
            _linksList.Add("blog/2021/04/22/انگولار-چیست؟", "/Blog/Post/انگولار-چیست؟");
            _linksList.Add("blog/2021/09/17/splash-screen-در-اندروید", "/Blog/Post/splash-screen-در-اندروید");
            _linksList.Add("blog/2021/09/02/آموزش-سی-شارپ-مقدماتی-ویدیو", "/Blog/Post/آموزش-سی-شارپ-مقدماتی-ویدیو");
            _linksList.Add("blog/2021/08/17/تاریخچه-مدیریت", "/Blog/Post/تاریخچه-مدیریت");
            _linksList.Add("blog/2021/07/08/route-constraint/", "/Blog/Post/route-constraint");
            _linksList.Add("blog/2021/07/23/retrofit-kotlin", "/Blog/Post/retrofit-kotlin");
            _linksList.Add("blog/2021/04/22/javascript", "/Blog/Post/javascript");
            _linksList.Add("my-account", "/Account");
            _linksList.Add("wp-content/uploads/2021/09/GoF_Design_Patterns_Reference0100.pdf", "/UploadedFiles/MediaUpload/2201191038_GoF_Design_Patterns_Reference0100.pdf");
            _linksList.Add("wp-content", "/");
            _linksList.Add("product-tag", "/shop");
            _linksList.Add("product-category", "/shop");
        }

    }
}