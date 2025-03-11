using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE1.Entities
{



    public class Instructor
    {
        [Key]
        public int Inst_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 
        public int salary { get; set; } 
        public int bouns { get; set; } 
        public int houre_rate { get; set; } 

        public int Dept_ID { get; set; } 

        [ForeignKey("Dept_ID")]
        public Department Department { get; set; }

        public ICollection<CourseInst> CourseInstructors { get; set; }

   
        [InverseProperty("HeadInstructor")]
        public Department DepartmentHeaded { get; set; }
    }
}
