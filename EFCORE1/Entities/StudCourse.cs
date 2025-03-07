using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{
    public class StudCourse
    {
        [Key]

        public int Stud_ID { get; set; }


        public int Course_ID { get; set; } 

        public int Grade { get; set; } 
    }
}