using D8TaskC_.Interface;
using System;

namespace D8TaskC_
{
    internal class Program
    {


        public static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }






            static void Main()
        {
            //باقي D7

            #region Problem1
            /*
              Problem: 
                 o Define an interface IShape with: 
                 1. A property Area (get-only). 
                 2. A method Draw(). 
                 o Create a class Rectangle implementing IShape with its own version of Draw() and 
                 Area. 
                 o Test the implementation. 
             */

            //IShape rect = new Rectangle(5, 3);
            //rect.Draw();
            //Console.WriteLine($"With Area = { rect.Area}");

            #endregion

            #region Problem2
            /*
              Problem: 
                 o Modify the IShape interface to include a default implementation of a method 
                 PrintDetails(). 
                 o Create a class Circle that implements IShape. 
                 o Call PrintDetails() on an instance of Circle. 
             */

            //IShape circle = new Circle(4);
            //circle.Draw();
            //circle.PrintDetails();

            #endregion

            #region Problem3
            /*
              Problem: 
                o Define an interface IMovable with a method Move(). 
                o Create a class Car implementing IMovable. 
                o Use an IMovable reference to access the Car object and call Move(). 
             */

            //IMovable myCar = new Car();
            //myCar.Move();

            #endregion

            #region Problem4
            /*
              Problem: 
                 o Create two interfaces, IReadable and IWritable, each with a method (Read() and 
                 Write()). 
                 o Create a class File that implements both interfaces. 
                 o Demonstrate using the File class. 
             */

            //File f = new File();
            //f.Read();
            //f.Write();

            #endregion

            #region Problem5
            /*
              Problem: 
                o Create a base class Shape with: 
                1. A virtual method Draw() that prints "Drawing Shape". 
                2. An abstract method CalculateArea() for area calculation. 
                o Create a derived class Rectangle overriding Draw() and implementing 
                CalculateArea(). 
                o Demonstrate the usage with objects of Rectangle. 
             */

            //Shape rect = new Rectangle(4.5, 4);

            //rect.Draw();

            //Console.WriteLine("\nArea = " + rect.CalculateArea());

            #endregion


            // D8 Part01
            #region Problem01
            /*
             Problem: 
                Create an interface IVehicle with methods StartEngine() and StopEngine(). 
                Implement this interface in two classes: Car and Bike. 
                Write a program to demonstrate this design by calling the methods on IVehicle objects.
             */

            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //Console.WriteLine();

            //bike.StartEngine();
            //bike.StopEngine();

            #endregion

            #region Problem02
            /*
             Problem: 
                 Create an abstract class Shape with an abstract method GetArea() and a non-abstract method 
                 Display(). 
                 Implement this class in Rectangle and Circle classes. 
                 Write a program to compare Shape's abstract class with an interface-based approach. 
             */

            //Shape rect = new Rectangle(5, 10);
            //Shape circ = new Circle(4);

            //IShape rect1 = new Rectangle(5, 3);
            //IShape circ1 = new Circle(4);

            //Console.WriteLine("**Using interface**\n");

            //rect1.Draw();
            //Console.WriteLine($"With Area = { rect1.Area}\n");
            //circ1.Draw();
            //Console.WriteLine($"With Area = {circ1.Area} \n");

            //Console.WriteLine("**Using abstract class**\n");

            //rect.Display();
            //Console.WriteLine($"Has Area: {rect.GetArea()}\n");
            //circ.Display();
            //Console.WriteLine($"Has Area: {circ.GetArea()} ");

            #endregion

            #region Problem03
            /*
             Problem: 
                Define a class Product with attributes Id, Name, and Price. 
                Implement the IComparable interface to compare products by Price. 
                Write a program to sort an array of Product objects. 
             */

            //Product[] products =
            //{
            //new Product { Id = 1, Name = "Laptop", Price = 1200 },
            //new Product { Id = 2, Name = "SmartWatch", Price = 300 },
            //new Product { Id = 3, Name = "Phone", Price = 800 },
            //new Product { Id = 4, Name = "Tablet", Price = 500 }
            //};

            //Array.Sort(products);

            //foreach (var p in products)
            //    Console.WriteLine($"{p.Name} - ${p.Price}");

            #endregion

            #region Problem04
            /*
             Problem: 
                Create a class Student with attributes Id, Name, and Grade. 
                Add a copy constructor to create a deep copy of a Student object. 
                Write a program to demonstrate shallow vs. deep copies. 
             */

            //Student s1 = new Student(1, "Ahmed", 90.5);
            //Student s2 = new Student(s1); // Deep copy
            //Student s3 = s1;

            //Console.WriteLine("S1: "+s1.ToString()+" / "+s1.GetHashCode());
            //Console.WriteLine("S2: "+ s2.ToString() +" / "+s2.GetHashCode());
            //Console.WriteLine("S3: "+ s3.ToString() +" / "+s3.GetHashCode());

            #endregion

            #region Problem05
            /*
             Problem: 
                Create an interface IWalkable with a method Walk(). 
                Implement explicit interface methods in a class Robot to handle IWalkable methods differently 
                than its own methods
             */

            //Robot r = new Robot();
            //r.Walk(); // Class method

            //IWalkable wr = new Robot();
            //wr.Walk(); // Explicit interface method

            #endregion

            #region Problem06
            /*
             Problem: 
                Define a struct Account with private attributes AccountId, AccountHolder, and Balance. 
                Provide public properties for accessing these attributes. 
                Write a program to demonstrate encapsulation in structs. 
             */

            //Account acc = new Account(1,"Ahmed",25000);

            //Console.WriteLine(acc.ToString()+"\n");

            //acc.AccountId = 101;
            //acc.AccountHolder = "Tamer";
            //acc.Balance = 50000;

            //Console.WriteLine(acc.ToString());


            #endregion

            #region Problem07
            /*
             Problem: 
                 Create an interface ILogger with a method Log(). 
                 Provide a default implementation for Log() in the interface. 
                 Override the default implementation in a class ConsoleLogger. 
             */

            //ILogger logger = new ConsoleLogger();

            //logger.Log("Hello World");

            #endregion

            #region Problem08
            /*
             Problem: 
                  Create a class Book with attributes Title and Author. 
                  Provide multiple constructors: a default constructor, one that takes only Title, and another that 
                  takes both Title and Author. 
                  Write a program to demonstrate constructor overloading. 
             */

            //Book b1 = new Book();
            //Book b2 = new Book("C# Basics");
            //Book b3 = new Book("OOP in C#", "Ahmed");

            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b2.ToString());
            //Console.WriteLine(b3.ToString());

            #endregion

            // Part02

            #region Create a Shape Series 
            /*
             o Define an interface IShapeSeries with the following: 
                    A property int CurrentShapeArea { get; set; }. 
                    A method void GetNextArea() to calculate the next shape's area. 
                    A method void ResetSeries() to reset the series. 
                   o Implement IShapeSeries for the following: 
                   1. SquareSeries: Calculates areas of squares with side lengths incrementing 
                   by 1 (e.g., 1x1, 2x2, 3x3). 
                   2. CircleSeries: Calculates areas of circles with radii incrementing by 1 (use 
                   Math.PI * radius * radius). 
                   o Write a method PrintTenShapes(IShapeSeries series) to display the first 10 
                   areas of any series.
             */

            //Console.WriteLine("=== Square Series ===");
            //PrintTenShapes(new SquareSeries());

            //Console.WriteLine("\n=== Circle Series ===");
            //PrintTenShapes(new CircleSeries());

            #endregion

            #region Implement Sorting for Shapes 
            /*
             o Create a class Shape with properties: 
                 string Name (e.g., "Square", "Circle"). 
                 double Area. 
                o Implement IComparable for sorting shapes by area. 
                o Create a list of shapes with various types (Square, Circle, Rectangle) and areas. 
                o Sort and display the shapes by area in ascending order using Array.Sort(). 
             */

            //Shapes[] sh =
            //   {
            //       new Shapes { Name = "Square", Area = 25 },
            //       new Shapes { Name = "Circle", Area = 78.5 },
            //       new Shapes { Name = "Rectangle", Area = 20 }
            //   };

            // Array.Sort(sh);
            // Console.WriteLine("=== Sorted Shapes by Area ===");
            // foreach (var s in sh)
            //     Console.WriteLine(s);

            #endregion

            #region Extend the Shape Hierarchy 
            /*
             o Create an abstract class GeometricShape with: 
                  Properties: double Dimension1, double Dimension2. 
                  Abstract method: double CalculateArea(). 
                  Abstract property: double Perimeter { get; }. 
                 o Create derived classes: 
                  Triangle: Override CalculateArea() using 0.5 * Dimension1 * 
                 Dimension2. 
                  Rectangle: Implement area as Dimension1 * Dimension2 and perimeter 
                 as 2 * (Dimension1 + Dimension2). 
                 o Write a program to create and display instances of these shapes. 
             */

            //GeometricShape rect = new Rectangle1 { Dimension1 = 5, Dimension2 = 10 };
            //GeometricShape tri = new Triangle { Dimension1 = 3, Dimension2 = 4 };

            //Console.WriteLine("=== Rectangle ===");
            //Console.WriteLine($"Area: {rect.CalculateArea()}, Perimeter: {rect.Perimeter}");

            //Console.WriteLine("\n=== Triangle ===");
            //Console.WriteLine($"Area: {tri.CalculateArea()}, Perimeter: {tri.Perimeter}");

            #endregion

            #region Implement Your Own Sorting 
            /*
             o Write your own SelectionSort method for sorting an integer array: 
                 public static void SelectionSort(int[] numbers) 
                 o Use this method to sort an array of shape areas generated in Part 2.  
             */

            //int[] numbers = { 34, 12, 56, 9, 1 };
            //Console.WriteLine("=== Before Sort ===");
            //Console.WriteLine(string.Join(", ", numbers));

            //SortHelper.SelectionSort(numbers);

            //Console.WriteLine("=== After Sort ===");
            //Console.WriteLine(string.Join(", ", numbers));
            #endregion

            #region Implement Factory Pattern 
            /*
             o Create a ShapeFactory class with a method CreateShape(string shapeType, 
                  double dim1, double dim2). 
                  o Use the factory to create instances of different geometric shapes (Rectangle, 
                  Triangle, etc.).  
             */

            //ShapeFactory factory = new ShapeFactory();

            //var shape1 = factory.CreateShape("rectangle", 6, 4);
            //var shape2 = factory.CreateShape("triangle", 3, 4);

            //Console.WriteLine("=== Factory Rectangle ===");
            //Console.WriteLine($"Area: {shape1.CalculateArea()}, Perimeter: {shape1.Perimeter}");

            //Console.WriteLine("\n=== Factory Triangle ===");
            //Console.WriteLine($"Area: {shape2.CalculateArea()}, Perimeter: {shape2.Perimeter}");

            #endregion




        }
    }
}
