using D2_MVC_Task.Models;

namespace D2_MVC_Task.ViewModels
{
    public class StudentListVM
    {
        public List<Student> Students { get; set; }
        public string Search { get; set; }
        public int? DepartmentId { get; set; }
        public List<Department> Departments { get; set; }

        // Pagination
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
