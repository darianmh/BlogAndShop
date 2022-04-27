using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.ViewModel.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.LearningSystem
{
    public class CourseRegisterRequestViewModel : BaseEntityModel
    {
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [AdminShowItem(1)]
        public string LastName { get; set; }
        [Display(Name = "شماره تماس")]
        [AdminShowItem(2)]
        public string PhoneNumber { get; set; }
        [Display(Name = "توضیح")]
        public string RegisterDescription { get; set; }
        [Display(Name = "دوره")]
        [ForeignKey("Course")]
        [AdminShowItem(3)]
        public int RegisterCourseId { get; set; }

        //np
        [JsonIgnore]
        public virtual CourseViewModel Course { get; set; }
    }
}
