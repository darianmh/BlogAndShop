using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public interface ICourseService : IMainService<Course>
    {
        /// <summary>
        /// دریافت ویو مدل دوره ها بر اساس سیستم
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        Task<List<CourseViewModel>> GetAllModelBySystemId(int systemId);
        /// <summary>
        /// دریافت  دوره ها بر اساس سیستم
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        Task<List<Course>> GetAllBySystemId(int systemId);
    }
}