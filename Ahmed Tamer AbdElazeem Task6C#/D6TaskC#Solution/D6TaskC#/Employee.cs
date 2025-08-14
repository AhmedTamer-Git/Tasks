using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6TaskC_
{
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;


        public Employee(int id, string name, double salary)
        {
            EmpId = id;
            Name = name;
            Salary = salary;
        }

        // Getter & Setter for Name
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Value)
        {
            Name = Value;
        }
        // Property for Salary
        public double EmpSalary
        {
            get { return Salary; }
            set { Salary = value < 6000 ? 6000 : value; }
        }
    }
}
