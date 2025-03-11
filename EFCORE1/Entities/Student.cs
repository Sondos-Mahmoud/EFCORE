using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE1.Entities
{
    public class Student
    {
        [Key]
        public int Stud_ID { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }

   
        public int Dep_ID { get; set; }

        
        [ForeignKey("Dep_ID")]
        public Department Department { get; set; }

      
        public ICollection<StudCourse> StudCourses { get; set; }
    }
}
