using System;
using System.Drawing;

namespace D9TaskC_
{

    //pro 4
    enum Gender : byte
    {
        Male,
        Female
    }

    //Pro 5
    enum Grades { A, B, C, D, F }




    internal class Program
    {

        static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }


        // Generic Method to Reverse Array
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] result = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }
            return result;
        }

        // Generic Method to Swap Elements
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        // Generic Method to Find Maximum
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Array is empty!");

            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }


        static void Main()
        {

            //Part01

            #region Problem01
            /*
              Problem: 
                Extend the Child class to include a method DisplaySalary that uses the sealed Salary 
                property. Instantiate the class and demonstrate the use of this method. 
             */

            //Child c = new Child();
            //c.Salary = 5000;
            //c.DisplaySalary();

            #endregion

            #region Problem02
            /*
              Problem: 
                  Write a static method in the Utility class to calculate the perimeter of a rectangle. Call it 
                  without creating an instance of the class. 
             */

            //Console.WriteLine(Utility.RectanglePerimeter(10, 5));


            #endregion

            #region Problem03
            /*
              Problem: 
                 Modify the ComplexNumber class to add operator overloading for the multiplication (*) 
                 operator. Demonstrate it with two complex numbers. 
             */

            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(1, 4);

            //ComplexNumber result = c1 * c2;
            //Console.WriteLine(result);

            #endregion

            #region Problem04
            /*
              Problem: 
                 Modify the Gender enum to use byte as its underlying type. Write a program to 
                 demonstrate its memory usage compared to the default int. 
             */

            //Console.WriteLine($"Size of int enum: {sizeof(int)} bytes");
            //Console.WriteLine($"Size of byte enum: {sizeof(byte)} bytes");

            #endregion

            #region Problem05
            /*
              Problem: 
                 Create a static method in the Utility class to convert temperatures between Celsius and 
                 Fahrenheit. Write code to demonstrate its usage.
             */

            //Console.WriteLine(Utility.CelsiusToFahrenheit(5));   // 41
            //Console.WriteLine(Utility.FahrenheitToCelsius(32)); // 0

            #endregion

            #region Problem06
            /*
              Problem: 
                Write a program that tries to parse a string to a Grades enum value. Use Enum.TryParse 
                to handle invalid inputs gracefully. 
             */

            //Console.Write("Enter grade (A, B, C, D, F): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, out Grades grade))
            //{
            //    Console.WriteLine($"Parsed successfully: {grade}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade input!");
            //}

            #endregion

            #region Problem07
            /*
              Problem: 
                 Enhance the Employee class to include Equals method. Demonstrate the correct usage of Equals 
                 when searching for an employee object in an array using Helper2<Employee>.SearchArray. 
             */


            //Employee[] employees = {
            //new Employee{Id=1, Name="Ahmed"},
            //new Employee{Id=2, Name="Tamer"},
            //new Employee{Id=3, Name="Ali"},
            //new Employee{Id=4, Name="Sara"}
            //};

            //Employee target = new Employee { Id = 4, Name = "Sara" };
            //int index = Helper2<Employee>.SearchArray(employees, target);
            //Console.WriteLine(index);

            #endregion

            #region Problem08
            /*
              Problem: 
                   Write a generic method Max in the Helper class that takes two arguments and returns the 
                   greater value. Demonstrate the usage of this method with integers, doubles, and strings.
             */

            //Console.WriteLine(Helper.Max(5, 10));
            //Console.WriteLine(Helper.Max(5.5, 2.3));
            //Console.WriteLine(Helper.Max("apple", "banana"));

            #endregion

            #region Problem09
            /*
              Problem: 
                 Add a new method ReplaceArray in the Helper2<T> class that replaces all occurrences of a 
                 specified value in an array with another value. Demonstrate with both integer and string arrays. 

             */

            //int[] nums = { 1, 2, 2, 3 };
            //Helper2<int>.ReplaceArray(nums, 2, 99);
            //Console.WriteLine(string.Join(", ", nums));

            //string[] words = { "hi", "hello", "hi" };
            //Helper2<string>.ReplaceArray(words, "hi", "bye");
            //Console.WriteLine(string.Join(", ", words));

            #endregion

            #region Problem10
            /*
              Problem: 
               Write a non-generic Swap method for a custom struct Rectangle with properties Length and 
               Width. Create instances of Rectangle and demonstrate swapping their values. 
             */

            // Rectangle a = new Rectangle { Length = 5, Width = 2 };
            // Rectangle b = new Rectangle { Length = 10, Width = 4 };

            //Console.WriteLine($" Before Swap\n a: {a}     b: {b}\n");

            // Swap(ref a, ref b);

            // Console.WriteLine($" After Swap\n a: {a}     b: {b}");

            #endregion

            #region Problem11
            /*
              Problem: 
                Create a Department class and use it to add a Department property to the Employee class. 
                Demonstrate searching an array of employees by department using the SearchArray method.
             */

            //Department d1 = new Department { Name = "HR" };
            //Department d2 = new Department { Name = "IT" };

            //Employee2[] employees = {
            //new Employee2{Id=1, Name="Ali", Dept=d1},
            //new Employee2{Id=2, Name="Ahmed", Dept=d2},
            // new Employee2{Id=3, Name="Omar", Dept=d2}
            //};

            //Employee2 target = new Employee2 { Id = 2, Dept = d2 };
            //int index = Helper2<Employee2>.SearchArray(employees, target);
            //Console.WriteLine(index);

            #endregion

            #region Problem12
            /*
              Problem: 
                  Create a custom struct Circle with properties Radius and Color. Compare its instances using both 
                  == and Equals. Demonstrate the difference in behavior when the same operations are 
                  performed on instances of a Circle class. 
             */

            //CircleStruct cs1 = new CircleStruct { Radius = 5, Color = "Red" };
            //CircleStruct cs2 = new CircleStruct { Radius = 5, Color = "Red" };

            //Console.WriteLine(cs1.Equals(cs2)); // true
            //Console.WriteLine(cs1 == cs2);      // true (value type default)

            //CircleClass cc1 = new CircleClass { Radius = 5, Color = "Red" };
            //CircleClass cc2 = new CircleClass { Radius = 5, Color = "Red" };

            //Console.WriteLine(cc1.Equals(cc2)); // true
            //Console.WriteLine(cc1 == cc2);      // false (reference type default)

            #endregion

            //Part02

            #region Problem1
            /*
             Problem 1: Generic Method for Reversing an Array
                  Description: Create a generic method to reverse the elements of an array.
                  Requirements:
                  The method should accept an array of any type and return a new array with the elements in reverse order.
                  Ensure the method works for different types such as integers, strings, and custom objects.
             */

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var reversed = ReverseArray(numbers);
            //Console.WriteLine("Reversed: " + string.Join(", ", reversed));

            #endregion

            #region Problem2
            /*
             Problem 2: Generic Class for a Stack
                Description: Implement a generic class for a stack data structure.
                Requirements:
                The class should support standard stack operations such as push, pop, and peek.
                Ensure type safety using generics.
             */

            //MyStack<string> stack = new MyStack<string>(5);
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");
            //Console.WriteLine("Peek: " + stack.Peek()); // C
            //Console.WriteLine("Pop: " + stack.Pop());   // C
            //Console.WriteLine("Pop: " + stack.Pop());   // B
            //Console.WriteLine("Peek: " + stack.Peek()); // A

            #endregion

            #region Problem3
            /*
             Problem 3: Generic Method for Swapping Elements
                Description: Implement a generic method to swap two elements in an array.
                Requirements:
                The method should accept an array and two indices.
                Swap the elements at the given indices.
             */

            //string[] words = { "apple", "banana", "cherry" };
            //Swap(words, 0, 2);
            //Console.WriteLine("Swapped: " + string.Join(", ", words));

            #endregion

            #region Problem4
            /*
             Problem 4: Generic Method for Finding Maximum Element
                Description: Implement a generic method to find the maximum element in an array.
                Requirements:
                The method should accept an array of any type that implements Comparable.
                Return the maximum element in the array.
             */

            //int[] nums = { 10, 50, 30, 70, 20 };
            //Console.WriteLine("Max: " + FindMax(nums)); // 70

            #endregion


        }
    }
}
