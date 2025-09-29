using D2_MVC_Task.Models;

namespace D2_MVC_Task.ViewModels
{
    public class StudentAddVM
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public List<Department> DeptList { get; set; }
    }

}
