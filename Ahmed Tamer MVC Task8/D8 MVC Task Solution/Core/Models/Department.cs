using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [MaxLength(50, ErrorMessage = "Name must be less than 50 characters")]
        [MinLength(2, ErrorMessage = "Name must be at least 3 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manager name is required")]
        [MaxLength(50, ErrorMessage = "Manager name must be less than 50 characters")]
        [RegularExpression(@"^[a-zA-Z.\s]+$", ErrorMessage = "Manager name can only contain letters and spaces")]
        public string MgrName { get; set; }
        // Navigation
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
