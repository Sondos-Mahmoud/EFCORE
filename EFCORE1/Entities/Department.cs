using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCORE1.Entities
{
 
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Inst_ID { get; set; } 
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [ForeignKey("Inst_ID")]
        public Instructor HeadInstructor { get; set; }

 
        public ICollection<Student> Students { get; set; }


        public ICollection<Instructor> Instructors { get; set; }
    }
}