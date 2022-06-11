using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Classes;

using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;
using CommonConfiguration.Core.Services.Main;

namespace BlogAndShop.Services.Services.Product
{
    public class ProductForumGroupService : MainServiceNonBaseEntity<Data.Data.Forum.Product_ForumInfo>, IProductForumGroupService
    {
        #region Fields


        #endregion
        #region Methods
        public async Task<Product_ForumInfo> Find(int productId, int forumId)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.ForumTitleId == forumId && x.ProductId == productId);
        }

        public async Task<List<Product_ForumInfo>> GetProductForums(int productId)
        {
            return await Queryable.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task Create(ForumTitle forum, int @group)
        {
            var item = new Product_ForumInfo() { ForumTitleId = forum.Id, ProductId = group };
            await InsertAsync(item);
        }

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ProductForumGroupService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion



    }
}