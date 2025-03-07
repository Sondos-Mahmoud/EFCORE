using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   
        [Table("Employees", Schema = "dbo")]
         class Employee
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
            public int EmpId { get; set; }

            [Required] // Required in the database
            [Column(TypeName = "varchar")]
            [MaxLength(50)]
            [StringLength(50, MinimumLength = 10)] // Ensures the length is between 10 and 50 characters
            public string Name { get; set; }

            [Column(TypeName = "money")] // Maps to SQL Server's `money` type
            public double Salary { get; set; }

            [Range(21, 60)] // Ensures the value is between 21 and 60
            public int? Age { get; set; } // Nullable int

            [EmailAddress] // Validates the email format
            [DataType(DataType.EmailAddress)] // Specifies the data type as email
            public string Email { get; set; }

            [Phone] // Validates the phone number format
            [DataType(DataType.PhoneNumber)] // Specifies the data type as phone number
            [NotMapped] // This property will not be mapped to the database
            public string PhoneNumber { get; set; }
            public string Address { get; internal set; }
    }
    }

