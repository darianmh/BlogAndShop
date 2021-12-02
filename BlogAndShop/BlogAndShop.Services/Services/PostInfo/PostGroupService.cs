using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostGroupService : MainService<PostGroup>, IPostGroupService
    {
        #region Fields

        private readonly IPostService _postService;

        #endregion
        #region Methods

        public async Task<List<LinkGroupHeaderViewModel>> GetHeaderModel()
        {
            var allActives = await GetAllAsync();
            var model = GetHeaderModel(allActives);
            return model;
        }

        public async Task<BlogListViewModel> GetPostModel(int? categoryId, int page, int count)
        {
            var posts = await _postService.GetPostsByGroup(categoryId, page, count);
            return new BlogListViewModel()
            {
                ListPaginationModel = new ListPaginationModel(posts.TotalCount > page * count, hasPre: page > 1, page: page, count: posts.List.Count, pagesCount: ((posts.TotalCount - 1) / count) + 1),
                Posts = posts.List.Select(x => x.ToModel()).ToList()
            };
        }

        #endregion
        #region Utilities

        /// <summary>
        /// تبدیل لیست دیتابیس به مدل هدر
        /// </summary>
        /// <param name="allActives"></param>
        /// <returns></returns>
        private List<LinkGroupHeaderViewModel> GetHeaderModel(List<PostGroup> allActives)
        {
            var model = new List<LinkGroupHeaderViewModel>();
            //پیمایش همه
            foreach (var productGroup in allActives)
            {
                //اگر پدر نداشت خودش گروه اصلی است
                if (productGroup.ParentId == null)
                {
                    //افزودن به عنوان پدر
                    model = AddAsParent(model, productGroup);
                }
                else
                {
                    //اگر گدر داشت زیر مجموعه پدر اضافه می شود
                    var parent = GetParent(productGroup.ParentId, allActives);
                    if (parent == null)
                    {
                        //افزودن به عنوان پدر
                        model = AddAsParent(model, productGroup);
                    }
                    else
                    {
                        //پیدا کردن پدر اصلی
                        var parentModel = model.FirstOrDefault(x => x.Id == parent.Id);
                        //افزودن به عنوان زیر گروه
                        parentModel?.SubGroups.Add(new LinkSubGroupViewModel()
                        {
                            Id = productGroup.Id,
                            Name = productGroup.Title
                        });
                    }
                }
            }

            return model;
        }
        private List<LinkGroupHeaderViewModel> AddAsParent(List<LinkGroupHeaderViewModel> model, PostGroup productGroup)
        {
            model.Add(new LinkGroupHeaderViewModel()
            {
                Id = productGroup.Id,
                Name = productGroup.Title
            });
            return model;
        }

        private PostGroup? GetParent(int? productGroupParentId, List<PostGroup> allActives)
        {
            //finding main parent
            var parent = allActives.FirstOrDefault(x => x.Id == productGroupParentId);
            if (parent == null) return null;
            //if parent is sub of other group
            if (parent.ParentId != null)
            {
                //find grand parent
                var tempParent = GetParent(parent.ParentId, allActives);
                //return if parent is not valid
                if (tempParent == null) return null;
                //set grand parent as direct parent
                parent = tempParent;
            }
            return parent;
        }


        #endregion
        #region Ctor
        public PostGroupService(ApplicationDbContext db, IPostService postService) : base(db)
        {
            _postService = postService;
        }
        #endregion

    }
}