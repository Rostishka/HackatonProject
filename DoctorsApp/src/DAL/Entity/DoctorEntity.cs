using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.Entity
{
    public class DoctorEntity : ApplicationUser
    {
        public int Age{ get; set; }
        public string Information{ get; set; }
        public List<string> Procedures { get; set; }
        public List<EducationEntity> Educations { get; set; }
        public ICollection<ExperienceEntity> Type { get; set; }
        public string Location{ get; set; }
        public ExperienceEntity CurrentWorkPlace{ get; set; }
    }
}
