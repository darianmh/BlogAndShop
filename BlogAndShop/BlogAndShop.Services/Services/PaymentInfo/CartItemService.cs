using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.User.Cart;
using BlogAndShop.Services.Services.Main;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public class CartItemService : MainService<CartItem>, ICartItemService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<List<CartItem>> GetItems(int modelId)
        {
            var items = await Queryable.Where(x => x.CartId == modelId).ToListAsync();
            return items;
        }

        public async Task<CartAddResponseModel> AddCartItem(UserCart userCart, Data.Data.Product.Product product,
            int quantity)
        {
            if (userCart == null) return new CartAddResponseModel() { Check = false, CartAddResult = CartAddResult.CartNotFound };
            if (product == null) return new CartAddResponseModel() { Check = false, CartAddResult = CartAddResult.ProductNotFound };
            if (product.Quantity < quantity) return new CartAddResponseModel() { Check = false, CartAddResult = CartAddResult.OutOfStock };
            var item = await GetItemByProductAndCart(userCart.Id, product.Id);
            if (item == null) await CreateItemByProductAndCart(userCart.Id, product.Id, quantity);
            else
            {
                item.Quantity = item.Quantity + quantity;
                await UpdateAsync(item);
            }
            return new CartAddResponseModel() { CartAddResult = CartAddResult.Add, Check = true };
        }

        public async Task CreateItemByProductAndCart(int userCartId, int productId, int quantity)
        {
            var item = new CartItem()
            {
                CartId = userCartId,
                ProductId = productId,
                Quantity = quantity
            };
            await InsertAsync(item);
        }

        public async Task RemoveCartItem(UserCart userCart, int productId)
        {
            var item = await GetItemByProductAndCart(userCart.Id, productId);
            if (item != null) await DeleteAsync(item);
        }

        public async Task<CartItem> GetItemByProductAndCart(int cartId, int productId)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.ProductId == productId && x.CartId == cartId);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public CartItemService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}