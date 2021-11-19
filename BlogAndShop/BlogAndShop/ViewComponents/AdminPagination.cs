using System.Threading.Tasks;
using BlogAndShop.Data.ViewModel.Common;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminPagination : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ListPaginationModel model)
        {
            return View(model);
        }

    }
}