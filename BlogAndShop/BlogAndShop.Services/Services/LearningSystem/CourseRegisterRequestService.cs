using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public class CourseRegisterRequestService : MainService<CourseRegisterRequest>, ICourseRegisterRequestService
    {
        #region Fields


        #endregion
        #region Methods


        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public CourseRegisterRequestService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}