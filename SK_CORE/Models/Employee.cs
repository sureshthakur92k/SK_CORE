using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SK_CORE.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column("EmployeeName",TypeName ="varchar(200)")]
        [Required]
        public string Name { get; set; }
        [Column("EmployeeGender", TypeName = "varchar(20)")]
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Column("EmployeeSalary", TypeName = "Int")]
        [Required]
        public int Salary { get; set; }
        [Column("EmployeeEmailId", TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; }
    }
}
