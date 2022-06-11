using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.ViewModel.PaymentInfo;

using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using Microsoft.EntityFrameworkCore;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class PaymentItemService : MainService<PaymentItem>, IPaymentItemService
    {
        #region Fields

        private readonly IProductService _productService;

        #endregion
        #region Methods

        public async Task<List<PaymentItemModel>> GetPaymentItemsModel(int userPaymentId)
        {
            var items = await GetPaymentItems(userPaymentId);
            var result = new List<PaymentItemModel>();
            foreach (var item in items)
            {
                var tempModel = await GetItemModel(item);
                result.Add(tempModel);
            }
            return result;
        }


        public async Task<List<PaymentItem>> GetPaymentItems(int userPaymentId)
        {
            return await Queryable.Where(x => x.ProductId == userPaymentId).ToListAsync();
        }
        public async Task<List<int>> GetTopProducts()
        {
            return await Queryable.GroupBy(x => x.ProductId).OrderBy(x => x.Count()).Select(x => x.Key).ToListAsync();
        }
        #endregion
        #region Utilities

        private async Task<PaymentItemModel> GetItemModel(PaymentItem item)
        {
            var model = item.ToModel();
            model.Product = await _productService.GetProductModel(model.ProductId);
            return model;
        }

        #endregion
        #region Ctor
        public PaymentItemService(ApplicationDbContext db, IProductService productService) : base(db)
        {
            _productService = productService;
        }
        #endregion

    }
}