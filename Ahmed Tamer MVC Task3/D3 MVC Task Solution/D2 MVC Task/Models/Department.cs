namespace D2_MVC_Task.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MgrName { get; set; }

        // Navigation
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
