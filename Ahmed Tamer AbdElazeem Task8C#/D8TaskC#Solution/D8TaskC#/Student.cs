using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        
        public Student(int id, string name, double grade)
               {
                   Id = id; 
                   Name = name; 
                   Grade = grade;
               }
        
        // Copy constructor (deep copy)
        public Student(Student Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name ;
            Grade = Copy.Grade;
        }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name} Grade: {Grade} ";         
        }
        
    }
}
