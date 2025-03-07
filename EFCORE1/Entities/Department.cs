using System.ComponentModel.DataAnnotations;

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
   
    }
}