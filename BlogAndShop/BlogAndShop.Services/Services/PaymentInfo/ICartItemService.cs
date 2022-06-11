using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.User.Cart;


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

        /// <summary>
        /// افزودن محصول به سبد خرید کاربر
        /// </summary>
        /// <param name="userCart"></param>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        Task<CartAddResponseModel> AddCartItem(UserCart userCart, Data.Data.Product.Product product, int quantity);

        /// <summary>
        /// دریافت آیتم بر اساس سبد خرید و محصول
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<CartItem> GetItemByProductAndCart(int cartId, int productId);

        /// <summary>
        /// افزودن آیتم بر اساس سبد خرید و محصول
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        Task CreateItemByProductAndCart(int userCartId, int productId, int quantity);
        /// <summary>
        /// حذف محصول از سبد خرید
        /// </summary>
        /// <param name="userCart"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task RemoveCartItem(UserCart userCart, int productId);
    }
}
