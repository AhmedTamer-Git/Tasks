using D2_MVC_Task.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D2_MVC_Task.ViewModels
{
    public class CourseVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Degree must be between 10 and 100")]
        public int Degree { get; set; }

        [Range(0, 100, ErrorMessage = "Min Degree must be between 5 and 100")]
        [Display(Name = "Minimum Degree")]
        public int MinDegree { get; set; }

        [ForeignKey("Department")]
        [Required(ErrorMessage = "Please select a department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<Department> DeptList { get; set; } = new List<Department>();

    }
}
