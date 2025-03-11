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
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Course_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        // Foreign Key
        public int Top_ID { get; set; } // Added based on ER diagram

        // Navigation Property
        [ForeignKey("Top_ID")]
        public Topic Topic { get; set; }

        // Many-to-Many with Student via StudCourse
        public ICollection<StudCourse> StudCourses { get; set; }

        // Many-to-Many with Instructor via CourseInst
        public ICollection<CourseInst> CourseInstructors { get; set; }
    }
}
