using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.LearningSystem
{
    public class LearningSystemLandingModel
    {
        public LearningSiteConfigViewModel ConfigModel { get; set; }
        public List<LearningSystemFooterLinkViewModel> Links { get; set; }
        public List<CourseViewModel> CoursesModel { get; set; }
    }
}
