﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public interface ICartItemService : IMainService<CartItem>
    {
        /// <summary>
        /// موارد موجود در سبد خرید کاربر را بر می گرداند
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        Task<List<CartItem>> GetItems(int modelId);
    }
}
