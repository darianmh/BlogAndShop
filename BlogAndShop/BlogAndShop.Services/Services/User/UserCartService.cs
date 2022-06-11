using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;

using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.Product;
using CommonConfiguration.Core.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.User
{
    public class UserCartService : MainService<UserCart>, IUserCartService
    {
        #region Fields

        private readonly ICartItemService _cartItemService;
        private readonly IProductService _productService;

        #endregion
        #region Methods
        public async Task<UserCart> GetUserCart(int userId)
        {
            var cart = await Queryable.FirstOrDefaultAsync(x => x.OwnerId == userId);
            if (cart == null)
                cart = await Create(userId);
            return cart;
        }

        public async Task<UserCartModel> GetUserCartModel(int userId)
        {

            var cart = await GetUserCart(userId);
            var model = await GetModel(cart);
            return model;
        }

        #endregion
        #region Utilities

        private async Task<UserCartModel> GetModel(UserCart cart)
        {
            var model = cart.ToModel();
            var cartItems = await _cartItemService.GetItems(model.Id);
            var cartItemsModel = await GetCardItemsProduct(cartItems);
            model.CartItems = cartItemsModel;
            model = GetPricingInfo(model);
            return model;
        }
        /// <summary>
        /// محاسبه قیمت محصولات در سبد خرید
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private UserCartModel GetPricingInfo(UserCartModel model)
        {
            var total = model.CartItems.Sum(x => x.TotalPrice);
            var off = model.CartItems.Sum(x => x.OffPriceTotal);
            model.OffPrice = off;
            model.ToPayPrice = total;
            model.TotalPrice = total + off;
            return model;
        }
        /// <summary>
        /// محاسبه قیمت هر آیتم در سبد خرید
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private CartItemModel GetPricingInfo(CartItemModel tempModel)
        {
            tempModel.OffPriceTotal =
                tempModel.Product.OffPrice == null ? 0
                : ((decimal)tempModel.Product.OffPrice) * tempModel.Quantity;
            tempModel.TotalPrice = (tempModel.Quantity * tempModel.Product.Price) - tempModel.OffPriceTotal;
            return tempModel;
        }

        private async Task<List<CartItemModel>> GetCardItemsProduct(List<CartItem> cartItems)
        {
            var result = new List<CartItemModel>();
            foreach (var cartItem in cartItems)
            {
                var product = await _productService.GetByIdAsync(cartItem.ProductId);
                if (product == null) continue;
                var productModel = product.ToModel();
                var tempModel = cartItem.ToModel();
                tempModel.Product = productModel;
                tempModel = GetPricingInfo(tempModel);
                result.Add(tempModel);
            }

            return result;
        }


        private async Task<UserCart> Create(int userId)
        {
            var model = new UserCart() { OwnerId = userId };
            await InsertAsync(model);
            return model;
        }

        #endregion
        #region Ctor
        public UserCartService(ApplicationDbContext db, ICartItemService cartItemService, IProductService productService) : base(db)
        {
            _cartItemService = cartItemService;
            _productService = productService;
        }
        #endregion


    }
}