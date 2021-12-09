using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Services.Services.Utilities
{
    public interface IAdminModelHelper
    {
        /// <summary>
        /// ایجاد مدل برای صفحه ایندکس پنل ادمین
        /// </summary>
        /// <returns></returns>
        AdminListViewModel<TModel> GetIndexModel<TModel, TBase>(DbModelInfo<TBase> all, int page, int count);
    }
}
