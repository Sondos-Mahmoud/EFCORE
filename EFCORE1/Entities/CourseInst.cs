using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{

    public class CourseInst
    {
        [Key]
        [Column(Order = 1)]
        public int Inst_ID { get; set; } // Instructor ID (part of the composite key)

        [Key]
        [Column(Order = 2)]
        public int Course_ID { get; set; } // Course ID (part of the composite key)

        public int Evaluate { get; set; } // Evaluation score
    }
}