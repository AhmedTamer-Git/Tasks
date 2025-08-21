using System;

namespace D7TaskC_
{
    internal class Program
    {
        static void Main()
        {

            #region Problem1
            /*
              Problem: 
                o Define a class Car with properties Id, Brand, and Price. 
                o Write multiple constructors: 
                1. Default constructor. 
                2. Constructor with one parameter (Id). 
                3. Constructor with two parameters (Id, Brand). 
                4. Constructor with all three parameters. 
                o Demonstrate the constructors by creating objects. 
             */

            //Car c1 = new Car();
            //Car c2 = new Car(1);
            //Car c3 = new Car(2, "Toyota");
            //Car c4 = new Car(3, "BMW", 50000);

            //Console.WriteLine("Default \n" + c1);
            //Console.WriteLine("\nOne parameter (Id) \n" + c2);
            //Console.WriteLine("\nTwo parameter (Id) \n" + c3);
            //Console.WriteLine("\nAll three parameters \n" + c4);

            #endregion

            #region Problem2
            /*
              Problem: 
                 o Write a class Calculator with overloaded Sum() methods to: 
                 1. Add two integers. 
                 2. Add three integers. 
                 3. Add two doubles. 
                 o Write a program to test each overload.
             */

            //Calculator calc = new Calculator();

            //Console.WriteLine($"Add two integers (2,3) = {calc.Sum(2, 3)} \n");
            //Console.WriteLine($"Add three integers (1,2,3) = {calc.Sum(1, 2, 3)} \n");
            //Console.WriteLine($"Add two doubles (2.5,3.7) = {calc.Sum(2.5, 3.7)}");   

            #endregion

            #region Problem3
            /*
              Problem: 
                o Create a base class Parent with properties X and Y, and a constructor to initialize them. 
                o Create a derived class Child with an additional property Z, and chain its constructor to 
                the base class. 
                o Demonstrate constructor chaining by creating an instance of Child.
             */

            //Child C1 = new Child(2, 3, 4);

            //Console.WriteLine($" X={C1.X}   Y={C1.Y}   Z={C1.Z}");

            #endregion

            #region Problem4
            /*
              Problem: 
                 o Define a method Product() in the Parent class to return X * Y. 
                 o In the Child class: 
                 1. Override the Product() method using the new keyword. 
                 2. Override it using the override keyword. 
                 o Demonstrate the difference in behavior using an instance of Child.
             */

            //Parent p = new Parent(2, 3);
            //Child c = new Child(2, 3, 4);
            //Parent pc = new Child(2, 3, 4);

            //Console.WriteLine(p.Product());  //with new 6     with override 6
            //Console.WriteLine(c.Product());  //with new 24    with override 24
            //Console.WriteLine(pc.Product()); //with new 6     with override 24

            #endregion

            #region Problem5
            /*
              Problem: 
                 o Override the ToString() method in Parent to return (X, Y) and in Child to return 
                 (X, Y, Z). 
                 o Demonstrate polymorphism by printing instances of both Parent and Child.
             */

            //Parent p = new Parent(1, 2);
            //Child c = new Child(1, 2, 3);

            //Console.WriteLine(p.ToString());
            //Console.WriteLine(c.ToString());

            #endregion

            
        }
    }
}
