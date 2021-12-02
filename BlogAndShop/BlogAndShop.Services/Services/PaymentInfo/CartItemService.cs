using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PaymentInfo;
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
            var items = await Queryable.Where(x => x.Id == modelId).ToListAsync();
            return items;
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