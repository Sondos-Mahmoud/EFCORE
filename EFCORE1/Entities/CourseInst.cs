using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{

  
    public class CourseInst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int Evaluate { get; set; }

        // Navigation Properties
        [ForeignKey("Inst_ID")]
        public Instructor Instructor { get; set; }

        [ForeignKey("Course_ID")]
        public Course Course { get; set; }
    }
}