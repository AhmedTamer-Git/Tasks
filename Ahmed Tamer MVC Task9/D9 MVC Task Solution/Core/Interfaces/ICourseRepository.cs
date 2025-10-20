using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        Course? GetById(int id);
        void Add(Course course);
        void Save(); // for Edit
        void Delete(int id);
    }
}
