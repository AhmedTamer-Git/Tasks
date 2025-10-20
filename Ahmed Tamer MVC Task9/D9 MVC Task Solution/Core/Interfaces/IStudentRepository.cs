using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student? GetById(int id);
        void Add(Student student);
        void Save(); // for Edit
        void Delete(int id);
    }
}
