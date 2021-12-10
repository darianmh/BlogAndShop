using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin.Product
{
    [AdminFilterName(AdminControllerNames.Product, "انجمن محصولات")]
    public class ProductForumGroupController : BaseAdminController
    {
        #region Fields

        private readonly IProductForumGroupService _service;

        #endregion
        #region Methods
        public async Task<IActionResult> Index(int page = 1, int count = 10)
        {
            var all = await _service.GetAllInfoAsync(page, count);
            //کسر یک عدد و سپس جمع آن برای رفع مشکل 10 تقسیم بر ده می باشد
            var model = AdminModelHelper.GetIndexModel<ProductForumGroupModel, Product_ForumInfo>(all, page, count);
            return View(model);
        }

        public async Task<IActionResult> Details(int ProductId, int ForumTitleId)
        {
            var item = await _service.Find(ProductId, ForumTitleId);
            var model = item.ToModel();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new ProductForumGroupModel());
        }
        public async Task<IActionResult> Edit(int ProductId, int ForumTitleId)
        {
            var item = await _service.Find(ProductId, ForumTitleId);
            var model = item.ToModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductForumGroupModel model)
        {
            var item = model.ToEntity();
            await _service.InsertAsync(item);
            return RedirectToAction("Details", new { ProductId = model.ProductId, ForumTitleId = model.ForumTitleId });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductForumGroupModel model)
        {
            var item = model.ToEntity();
            await _service.UpdateAsync(item);
            return RedirectToAction("Details", new { ProductId = model.ProductId, ForumTitleId = model.ForumTitleId });
        }

        public async Task<IActionResult> Delete(int ProductId, int ForumTitleId)
        {
            var item = await _service.Find(ProductId, ForumTitleId);
            await _service.DeleteAsync(item);
            return RedirectToAction("Index");
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public ProductForumGroupController(IProductForumGroupService service, IAdminModelHelper adminModelHelper) : base(adminModelHelper)
        {
            _service = service;
        }
        #endregion


    }
}