using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductCallRequestService : MainService<ProductCallRequest>, IProductCallRequestService
    {

        #region Fields

        private readonly IProductService _productService;

        #endregion
        #region Methods

        public async Task<List<NewNotificationModel>> GetNewOrders()
        {
            var allNew = await Queryable.Where(x => x.MessageStatus == MessageStatus.New).ToListAsync();
            return allNew.Select(async x =>
            {
                var text = await _productService.GetProductName(productId: x.ProductId);
                return new NewNotificationModel
                {
                    Id = x.Id,
                    Date = x.CreateDateTime,
                    NewNotificationType = NewNotificationType.Product,
                    Text = text
                };
            }).Select(x => x.Result).ToList();
        }

        public async Task<bool> CreateNew(ProductCallRequest item)
        {
            var check = await _productService.CheckIdAsync(item.ProductId);
            if (!check) return false;
            await InsertAsync(item);
            return true;
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductCallRequestService(ApplicationDbContext db, IProductService productService) : base(db)
        {
            _productService = productService;
        }
        #endregion


    }
}