using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE1.Entities
{
    #region convention
    //internal class Course
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public string Duration { get; set; }


    //} 
    #endregion
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Course_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }


    }
}
