using D2_MVC_Task.Models;
using System.ComponentModel.DataAnnotations;

namespace D2_MVC_Task.ViewModels
{
    public class StudentEditVM
    {
        public int Id { get; set; }       // Student Id
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required")]
        [Range(15, 100, ErrorMessage = "Age must be between 15 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a department")]
        public int DepartmentId { get; set; }

        public List<Department> DeptList { get; set; } = new List<Department>();
    }
}
