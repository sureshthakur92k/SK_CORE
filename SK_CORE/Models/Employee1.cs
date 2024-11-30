using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SK_CORE.Models
{
    public class Employee1
    {
        [Key]

        public int Id { get; set; }
        [Column("EmployeeName", TypeName = "varchar(200)")]
        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Please Enter Minimum 5 Char")]
        public string Name { get; set; }
        [Column("EmployeeGender", TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Please Enter Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter Age")]
        [Range(25, 45, ErrorMessage = "Age Should be min 25 and max 45")]
        public int Age { get; set; }
        [Column("EmployeeSalary", TypeName = "Int")]
        [Required(ErrorMessage = "Please Enter Salary")]
        [Range(25, 45, ErrorMessage = "Age Should be min 25 and max 45")]
        public int Salary { get; set; }
        [Column("EmployeeEmailId", TypeName = "varchar(100)")]
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter website url")]
        [Display(Name = "Website Url")]
        [Url]
        public string WebSite { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
