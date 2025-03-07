using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE1.Entities
{
    internal class Instructor
    {
        [Key]

        public int Inst_ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int salary { get; set; }
        public int bouns { get; set; }
        public int houre_rate { get; set; }



    }
}
