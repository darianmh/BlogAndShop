using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.ViewModel.LearningSystem;
using CommonConfiguration.Core.Services.Main;

using BlogAndShop.Services.Services.Mapper;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.LearningSystem
{
    public class CourseService : MainService<Course>, ICourseService
    {
        #region Fields


        #endregion
        #region Methods


        public async Task<List<CourseViewModel>> GetAllModelBySystemId(int systemId)
        {
            var all = await GetAllBySystemId(systemId);
            return all.Select(x => MapperService.ToModel((Course) x)).ToList();

        }

        public async Task<List<Course>> GetAllBySystemId(int systemId)
        {
            return await Queryable.Where(x => x.SystemName == systemId).ToListAsync();
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public CourseService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}