﻿using System;
using System.Linq;
using System.Reflection;
using BlogAndShop.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Classes
{
    public static class MyExtensions
    {
        /// <summary>
        /// find generic type in db set
        /// </summary>
        /// <param name="_context"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IQueryable<object> Set(this ApplicationDbContext _context, Type t)
        {
            var type = _context.GetType();
            var methods = type.GetMethods();
            var method = methods.FirstOrDefault(x => x.Name == "Set");
            var generic = method?.MakeGenericMethod(t);
            var result = generic.Invoke(_context, null);
            return (IQueryable<object>)result;
        }
    }
}