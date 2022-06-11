using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonConfiguration.Core.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.LearningSystem
{
    public class CourseRegisterRequest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string RegisterDescription { get; set; }
        [ForeignKey("Course")]
        public int RegisterCourseId { get; set; }

        //np
        [JsonIgnore]
        public virtual Course Course { get; set; }
    }
}
