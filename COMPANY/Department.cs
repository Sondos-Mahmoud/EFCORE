using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo
{
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }
    
        public string Name { get; set; }
    
        public DateTime HiringDate { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}