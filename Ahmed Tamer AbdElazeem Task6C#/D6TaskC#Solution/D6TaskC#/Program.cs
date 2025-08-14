using System;


namespace D6TaskC_
{
    internal class Program
    {


        static void ModifyStruct(Point p)
        {
            p.X = 100; // This changes only the local copy
        }

        static void ModifyClass(Employee1 e)
        {
            e.X = 100; // This changes the original object
        }


        static void Main()
        {


            #region Problem1
            /*
              Problem: 
                 o Create a struct Point with X and Y attributes. 
                 o Add constructors: default and parameterized. 
                 o Override the ToString() method to print the point as (X, Y). 
             */

            //Point p1 = new Point();
            //Point p2 = new Point(5, 10);

            //Console.WriteLine(p1); // (0, 0)
            //Console.WriteLine(p2); // (5, 10)
            #endregion

            #region Problem2
            /*
              Problem: 
                o Create a class TypeA with attributes F (private), G (internal), and H (public). 
                o Write a program to access these attributes from different parts of the project. 
             */

            //TypeA obj = new TypeA();

            ////Console.WriteLine("F = "+obj.F); //Error: private
            //Console.WriteLine("G = "+obj.G); // Access if in same assembly
            //Console.WriteLine("H = " + obj.H); //Public access

            //obj.ShowValues();

            #endregion

            #region Problem3
            /*
             Problem: 
              o Define a struct Employee with private attributes (EmpId, Name, Salary). 
              o Use methods (GetName, SetName) and properties to access these attributes. 
              o Write a test program to demonstrate encapsulation in action. 
             */

            //Employee emp = new Employee(1, "Ahmed", 5000);

            //Console.WriteLine("Name: " + emp.GetName());
            //emp.SetName("Omar");
            //Console.WriteLine("Updated Name: " + emp.GetName());

            //emp.EmpSalary = 6500;
            //Console.WriteLine("Updated Salary: " + emp.EmpSalary);

            #endregion

            #region Problem4
            /*
              Problem: 
                     o Define a struct Point with: 
                      A parameterized constructor initializing X to specific value and Y to 0. 
                      A parameterized constructor to set X and Y to specific values. 
                     o Write a test program to demonstrate constructor overloading. 
             */

            //Point p1 = new Point(5);
            //Point p2 = new Point(3, 7);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion

            #region Problem5
            /*
              Problem: 
                 o Modify the ToString() method of the Point struct to include custom formatting. 
                 o Write a program to test this by creating and printing multiple points. 
             */

            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(10, 20);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion

            #region Problem6
            /*
             Problem: 
               o Create a struct Point and a class Employee. 
               o Write a program to demonstrate value type (struct) and reference type (class) behavior 
               when passing them to methods. 
             */

            //Point structPoint = new Point { X = 10 };
            //Employee1 classEmployee = new Employee1 { X = 10 };

            //Console.WriteLine("Before method calls:");
            //Console.WriteLine($"Struct Point X: {structPoint.X}");
            //Console.WriteLine($"Class Employee X: {classEmployee.X}");

            //ModifyStruct(structPoint);
            //ModifyClass(classEmployee);

            //Console.WriteLine("\nAfter method calls:");
            //Console.WriteLine($"Struct Point X: {structPoint.X}");   // Still 10
            //Console.WriteLine($"Class Employee X: {classEmployee.X}"); // Changed to 100

            #endregion


        }
    }
}
