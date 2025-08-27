using System;
using System.Collections.Generic;
using System.Linq;

namespace D10TaskC_
{
    //pro13
    public delegate R Transformer<T, R>(T item);

    internal class Program
    {
        //pro9
        public static T GetDefault<T>()
        {
            return default(T);
        }

        //pro11
        public delegate string StringTransformer(string input);
        public static List<string> TransformStrings(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();
            foreach (var s in list) result.Add(transformer(s));
            return result;
        }

        //pro12
        public delegate int IntOperation(int a, int b);
        public static int Perform(int a, int b, IntOperation op) => op(a, b);

        //pro13
        public static List<R> Transform<T, R>(List<T> list, Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();
            foreach (var item in list) result.Add(transformer(item));
            return result;
        }

        //pro14
        public static List<int> Apply(List<int> list, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in list) result.Add(func(item));
            return result;
        }

        //pro15
        public static void Apply(List<string> list, Action<string> action)
        {
            foreach (var item in list) action(item);
        }

        //pro16
        public static List<int> Filter(List<int> list, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
                if (predicate(item)) result.Add(item);
            return result;
        }

        //pro17 pro19
        public static List<string> Filter(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
                if (condition(item)) result.Add(item);
            return result;
        }

        


        static void Main()
        {

            #region Problem01
            /*
             Problem: 
                Implement a sorting algorithm using the SortingAlgorithm<T> class for an array of 
                Employee objects based on their salary in ascending order.
             */

            //Employee[] employees = new Employee[]
            //{
            //new Employee { Name = "Ali", Salary = 5000 },
            //new Employee { Name = "Sara", Salary = 7000 },
            //new Employee { Name = "Omar", Salary = 4000 }
            //};

            //SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();
            //sorter.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));

            //Console.WriteLine("Employees sorted by Salary (ascending):");
            //foreach (var emp in employees)
            //    Console.WriteLine(emp);

            #endregion

            #region Problem02
            /*
              Problem: 
                 Modify the SortingTwo<T>.Sort method to dynamically sort integers in descending order 
                 using a lambda expression. 
             */

            //int[] numbers = { 5, 2, 8, 1, 3 };

            //SortingTwo<int> sorter = new SortingTwo<int>();
            //sorter.Sort(numbers, (x, y) => y.CompareTo(x)); // Descending

            //Console.WriteLine(string.Join(", ", numbers));

            #endregion

            #region Problem03
            /*
               Problem: 
                Write a comparer function to sort strings based on their length in ascending order using 
                SortingTwo<T>.Sort.
             */

            //string[] words = { "cat", "elephant", "lion" };

            //SortingTwo<string> sorter = new SortingTwo<string>();
            //sorter.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            //Console.WriteLine(string.Join(", ", words));

            #endregion

            #region Problem04
            /*
             Problem: 
               Add a new class Manager that inherits from Employee and implements 
               IComparable<Manager>. Update the sorting logic to include Manager objects and 
               compare by Salary. 
             */

            //Manager[] managers =
            //{
            //new Manager { Name = "Ali", Salary = 7000 },
            //new Manager { Name = "Mona", Salary = 6000 },
            //new Manager { Name = "Hany", Salary = 8000 }
            //};

            //Array.Sort(managers);

            //foreach (var m in managers)
            //    Console.WriteLine($"{m.Name} - {m.Salary}");

            #endregion

            #region Problem05
            /*
             Problem: 
                Create a delegate Func<T, T, bool> to compare Employee objects based on their Name 
                length and sort an array of employees.
             */

            //Employee[] employees = {
            //new Employee { Name="Ali", Salary=5000 },
            //new Employee { Name="Ahmed", Salary=6000 },
            //new Employee { Name="Mohamed", Salary=4000 }
            //};

            //Func<Employee, Employee, bool> compareByNameLength = (a, b) => a.Name.Length < b.Name.Length;

            //Array.Sort(employees, (a, b) => compareByNameLength(a, b) ? -1 : 1);

            //Console.WriteLine("Employees sorted by Name Length:");
            //foreach (var e in employees) Console.WriteLine(e);

            #endregion

            #region Problem06
            /*
             Problem: 
                Use an anonymous function to sort an integer array in ascending order. Demonstrate the 
                same logic with a lambda expression.
             */

            //int[] numbers1 = { 9, 2, 7, 1 };

            //Array.Sort(numbers1, delegate (int a, int b) { return a.CompareTo(b); });

            //Console.WriteLine("Sorted with Anonymous Function:");
            //foreach (var n in numbers1) Console.WriteLine(n);

            //int[] numbers2 = { 9, 2, 7, 1 };

            //Array.Sort(numbers2, (a, b) => a.CompareTo(b));

            //Console.WriteLine("Sorted with Lambda Expression:");
            //foreach (var n in numbers2) Console.WriteLine(n);

            #endregion

            #region Problem07
            /*
             Problem: 
                Enhance the SortingAlgorithm<T> class by implementing a standalone generic method 
                Swap<T> and demonstrate swapping elements of an integer array. 
             */

            //int a = 5, b = 10;
            //Console.WriteLine($"Before Swap: a={a}, b={b}");
            //SortingAlgorithm<int>.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a={a}, b={b}");

            #endregion

            #region Problem08
            /*
             Problem: 
                  Extend SortingTwo<T>.Sort to sort Employee objects first by Salary, and in case of ties, 
                  by Name using a custom comparer. 
             */

            //Employee[] employees = {
            //new Employee { Name="Ali", Salary=4000 },
            //new Employee { Name="Sara", Salary=4000 },
            //new Employee { Name="Baha", Salary=4000 },
            //new Employee { Name="Omar", Salary=3000 }
            //};

            //SortingTwo<Employee> sorter = new SortingTwo<Employee>();
            //sorter.Sort(employees, (a, b) =>
            //{
            //    int result = a.Salary.CompareTo(b.Salary);
            //    return result == 0 ? a.Name.CompareTo(b.Name) : result;
            //});

            //Console.WriteLine("Employees sorted by Salary then Name:");
            //foreach (var e in employees) Console.WriteLine(e);

            #endregion

            #region Problem09
            /*
             Problem: 
             Write a method GetDefault that uses default(T) to return the default value of generic 
             types and demonstrate its use with value types and reference types. 
             */

            //int defaultInt = GetDefault<int>();
            //string defaultStr = GetDefault<string>();

            //Console.WriteLine($"Default int: {defaultInt}");
            //Console.WriteLine($"Default string: {(defaultStr == null ? "null" : defaultStr)}");

            #endregion

            #region Problem10
            /*
             Problem: 
                  Add a constraint to the SortingAlgorithm<T> class to ensure T implements ICloneable. 
                  Demonstrate cloning an Employee array before sorting it.
             */

            //EmployeeClone[] employees = {
            //new EmployeeClone { Name="Ali", Salary=5000 },
            //new EmployeeClone { Name="Sara", Salary=3000 }
            //};

            //SortingAlgorithm<EmployeeClone> sorter = new SortingAlgorithm<EmployeeClone>();
            //var cloned = sorter.CloneArray(employees);

            //Console.WriteLine("Cloned Employees:");
            //foreach (var e in cloned) Console.WriteLine(e);

            #endregion

            #region Problem11
            /*
             Create a delegate that takes a string and returns a string. Implement a function that 
              applies this delegate to each element in a list of strings and returns the transformed list. 
              Test with different transformations like converting to uppercase, reversing the string, etc. 
             */

            //List<string> words = new List<string> { "hello", "world" };

            //var upper = TransformStrings(words, s => s.ToUpper());
            //Console.WriteLine("Uppercase: " + string.Join(", ", upper));

            //var reversed = TransformStrings(words, s => new string(s.Reverse().ToArray()));
            //Console.WriteLine("Reversed: " + string.Join(", ", reversed));

            #endregion

            #region Problem12
            /*
             Problem: 
                 Create a delegate that takes two integers and returns an integer. Implement a function that 
                 takes two integers and a delegate and performs the operation defined by the delegate. 
                 Test with different operations like addition, subtraction, multiplication, and division. 
             */

            //Console.WriteLine("Addition: " + Perform(5, 3, (x, y) => x + y));
            //Console.WriteLine("Subtraction: " + Perform(5, 3, (x, y) => x - y));
            //Console.WriteLine("Multiplication: " + Perform(5, 3, (x, y) => x * y));
            //Console.WriteLine("Division: " + Perform(6, 3, (x, y) => x / y));

            #endregion

            #region Problem13
            /*
             Problem: 
                 Define a generic delegate that takes a parameter of type T and returns a value of type R. 
                 Implement a function that transforms a list of type T into a list of type R using this 
                 delegate. Test with different transformations like converting a list of integers to their 
                 string representations. 
             */

            //List<int> numbers = new List<int> { 1, 2, 3 };
            //var strings = Transform(numbers, x => x.ToString());

            //Console.WriteLine("Transformed Integers to Strings: " + string.Join(", ", strings));

            #endregion

            #region Problem14
            /*
             Problem: 
                 Use Func<T, TResult> to create a delegate that takes an integer and returns its square. 
                 Implement a function that applies this delegate to each element in a list of integers and 
                 returns the list of results.
             */

            //List<int> numbers = new List<int> { 2, 3, 4 };
            //var squares = Apply(numbers, x => x * x);

            //Console.WriteLine("Squares: " + string.Join(", ", squares));

            #endregion

            #region Problem15
            /*
             Problem: 
               Use Action<T> to create a delegate that takes a string and prints it to the console. 
               Implement a function that takes a list of strings and an Action<string> delegate and 
               applies the action to each string in the list.
             */

            //List<string> words = new List<string> { "C#", "AI", "OpenAI" };
            //Apply(words, s => Console.WriteLine("Word: " + s));

            #endregion

            #region Problem16
            /*
             Problem: 
                 Use Predicate<T> to create a delegate that checks if an integer is even. Implement a 
                 function that filters a list of integers based on this predicate and returns the list of even 
                 numbers.
             */

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 6 };
            //var evens = Filter(numbers, n => n % 2 == 0);

            //Console.WriteLine("Even Numbers: " + string.Join(", ", evens));

            #endregion

            #region Problem17
            /*
             Problem: 
                Implement a function that filters a list of strings based on a condition provided by an 
                anonymous function. Test with different conditions like strings that start with a specific 
                letter or contain a specific substring. 
             */

            //List<string> words = new List<string> { "apple", "banana", "cherry" };
            //var startsWithB = Filter(words, delegate (string s) { return s.StartsWith("b"); });

            //Console.WriteLine("Strings starting with 'b': " + string.Join(", ", startsWithB));


            #endregion

            #region Problem18
            /*
             Problem: 
                 Implement a function that performs a mathematical operation on two integers using an 
                 anonymous function. Test with different operations like addition, subtraction, and 
                 multiplication. 
             */

            //Func<int, int, int> add = delegate (int a, int b) { return a + b; };
            //Func<int, int, int> multiply = delegate (int a, int b) { return a * b; };

            //Console.WriteLine("Addition: " + add(4, 5));
            //Console.WriteLine("Multiplication: " + multiply(4, 5));

            #endregion

            #region Problem19
            /*
             Problem: 
                 Implement a function that filters a list of strings based on a condition provided by a 
                 lambda expression. Test with conditions like strings that have a length greater than 3 or 
                 contain the letter 'e'.
             */

            //List<string> words = new List<string> { "car", "apple", "bike", "elephant" };
            //var filtered = Filter(words, s => s.Length > 3 && s.Contains("e"));

            //Console.WriteLine("Filtered Strings: " + string.Join(", ", filtered));

            #endregion

            #region Problem20
            /*
             Problem: 
                  Implement a function that performs a mathematical operation on two doubles using a 
                  lambda expression. Test with operations like division and exponentiation. 
             */

            //Func<double, double, double> divide = (a, b) => a / b;
            //Func<double, double, double> power = (a, b) => Math.Pow(a, b);

            //Console.WriteLine("Division: " + divide(10, 2));
            //Console.WriteLine("Exponentiation: " + power(2, 3));

            #endregion



        }
    }
}
