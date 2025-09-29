using D2_MVC_Task.Models;

namespace D2_MVC_Task.ViewModels
{
    public class StudentEditVM
    {
        public int Id { get; set; }       // Student Id
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; } // Selected Department

        // عشان نعرض الأقسام كلها في الـ DropDown
        public List<Department> DeptList { get; set; }
    }
}
