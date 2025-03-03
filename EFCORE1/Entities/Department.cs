using System.ComponentModel.DataAnnotations;

namespace EFCORE1.Entities
{
    public class Department
    {
        
        public int ID { get; set; }

        public string Name { get; set; }

        public int Ins_ID { get; set; } 
   
        public DateTime HiringDate { get; set; }
    }
}