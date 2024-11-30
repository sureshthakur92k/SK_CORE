using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace SK_CORE.Models
{
    public class Student
    {
       public int Id_ { get; set; }
        [Display(Name ="Name")]
        public string Name_ { get; set; }
       public string Class_ { get; set; }
        public int Age_ { get; set; }
        public string? Branch_ { get; set; }
        public string? Section_ { get; set; }
        [Display(Name = "Gender")]
        public Gender Gender_ { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }
        //  public List<SelectListItem> Class_ { get; set; }
    }
    public enum Gender
    {
        Male,Female
    }
    
}
