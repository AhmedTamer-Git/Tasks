using System;

namespace D5TaskC_
{
    internal class Program
    {
        static void Main()
        {

            //Part01

            #region Problem1
            /*
              Problem: Write a program that: 
                      o Reads two integers from the user and divides them. 
                      o Catches DivideByZeroException and displays an appropriate message. 
                      o Uses a finally block to print "Operation complete" regardless of success or failure.
             */

            //try
            //{
            // int num1, num2;
            // // Input first integer
            // while (true)
            // {
            //     Console.Write("Enter first integer: ");
            //     if (int.TryParse(Console.ReadLine(), out num1))
            //         break;
            //     else
            //         Console.WriteLine("Invalid input. Please enter a valid integer.");
            // }
            // // Input second integer
            // while (true)
            // {
            //     Console.Write("Enter second integer: ");
            //     if (int.TryParse(Console.ReadLine(), out num2))
            //         break;
            //     else
            //         Console.WriteLine("Invalid input. Please enter a valid integer.");
            // }

            // int result = num1 / num2;
            // Console.WriteLine($"Result: {result}");
            //} 
            //catch (DivideByZeroException)
            //{
            //     Console.WriteLine("Error: Cannot divide by zero!");
            //}
            //finally
            //{
            //     Console.WriteLine("Operation complete");
            //}

            #endregion

            #region Problem2
            /*
             Problem: Modify the TestDefensiveCode method in demo to: 
                     o Accept only positive integers for both X and Y. 
                     o Ensure Y is greater than 1. 
             */

            //int x, y;
            //while (true)
            //{
            //    Console.Write("Enter positive integer X: ");
            //    if (int.TryParse(Console.ReadLine(), out x) && x >= 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Enter a positive integer.");
            //}

            //while (true)
            //{
            //    Console.Write("Enter positive integer Y (> 1): ");
            //    if (int.TryParse(Console.ReadLine(), out y) && y > 1)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Enter a positive integer greater than 1.");
            //}

            //Console.WriteLine($"X = {x}, Y = {y}");

            #endregion

            #region Problem3
            /*
              Problem: Write a program that: 
                   o Declares a nullable integer. 
                   o Uses the null-coalescing operator (??) to assign a default value if the variable is null. 
                   o Demonstrates the difference between using HasValue and Value properties. 
             */

            //int? num = null;
            //int value = num ?? 10;
            //Console.WriteLine($"Value after ?? operator: {value}");

            //num = 20;
            //Console.WriteLine($"HasValue: {num.HasValue}");
            //if (num.HasValue)
            //    Console.WriteLine($"Value property: {num.Value}");
            #endregion

            #region Problem4
            /*
              Problem: Create a program to: 
                  o Declare a 1D array of size 5. 
                  o Try accessing an index out of bounds and handle the IndexOutOfRangeException. 
             */

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.WriteLine(arr[7]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index is out of bounds!");
            //}

            #endregion

            #region Problem5
            /*
              Problem: Write a program that: 
                    o Creates a 3x3 array with user-provided values. 
                    o Calculates and prints the sum of elements in each row and column. 
             */

            //int[,] matrix = new int[3, 3];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1);)
            //    {
            //        Console.Write($"Row {i} Column {j}: ");
            //        bool flag = int.TryParse(Console.ReadLine(), out matrix[i,j]);
            //        if (flag)
            //            j++;
            //    }
            //  Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int sumRow = 0;
            //    for (int j = 0; j < 3; j++)
            //        sumRow += matrix[i, j];
            //    Console.WriteLine($"Sum of row {i}: {sumRow}");
            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    int sumCol = 0;
            //    for (int i = 0; i < 3; i++)
            //        sumCol += matrix[i, j];
            //    Console.WriteLine($"Sum of column {j}: {sumCol}");
            //}

            #endregion

            #region Problem6
            /*
              Problem: Write a program that: 
                  o Creates a jagged array with three rows of varying sizes. 
                  o Populates each row with user input. 
                  o Prints all values row by row.
             */

            //int[][] jagged = new int[3][];
            //jagged[0] = new int[2];
            //jagged[1] = new int[3];
            //jagged[2] = new int[4];

            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length;)
            //    {
            //        Console.Write($"Enter value for row {i}, col {j}: ");
            //        bool flag = int.TryParse(Console.ReadLine(), out jagged[i][j]);
            //                if (flag)
            //                    j++;
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Jagged array contents:");
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    foreach (var val in jagged[i])
            //        Console.Write(val + " ");
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem7
            /*
              Problem: Demonstrate the use of nullable reference types by: 
                     o Declaring a nullable string. 
                     o Assigning it a value conditionally based on user input. 
                     o Using the null-forgiveness operator (!) to suppress warnings.
             */

            //#nullable enable

            //            string? name = null;
            //            Console.Write("Enter name (or leave blank): ");
            //            string input = Console.ReadLine()!;
            //            if (!string.IsNullOrWhiteSpace(input))
            //                name = input;
            //            Console.WriteLine($"Name: {name!}");

            //#nullable disable

            #endregion

            #region Problem8
            /*
              Problem: Write a program that: 
                  o Demonstrates boxing by assigning a value type to an object. 
                  o Demonstrates unboxing and checks for invalid cast exceptions. 
             */


            //object numBox = 45;
            //Console.WriteLine($"Boxed value: {numBox}");

            //try
            //{
            //    int unboxed = (int)numBox;
            //    Console.WriteLine($"Unboxed value: {unboxed}");
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Invalid cast during unboxing.");
            //}

            #endregion

            #region Problem9
            /*
              Problem: Write a method SumAndMultiply that: 
                    o Accepts two integers and calculates their sum and product using out parameters. 
                    o Calls the method and prints the results. 
             */

            //int a = 3, b = 4;
            //int sum = a + b;
            //int product = a * b;
            //Console.WriteLine($"Sum: {sum}, Product: {product}");

            #endregion

            #region Problem10
            /*
              Problem: Create a method that: 
                    o Accepts a string and an optional integer (default value: 5). 
                    o Prints the string the specified number of times. 
                    o Demonstrates the use of named parameters. 
             */

            //void PrintMultiple(string text, int count = 5)
            //{
            //    for (int i = 0; i < count; i++)
            //        Console.WriteLine(text);
            //}

            //PrintMultiple("Hello");
            //PrintMultiple("Hi", 3);
            //PrintMultiple(count: 2, text: "Custom");

            #endregion

            #region Problem11
            /*
              Problem: Write a program that: 
                     o Declares a nullable integer array. 
                     o Uses the null propagation operator (?.) to safely access its properties.
             */

            //int[]? arrNullable = null;
            //Console.WriteLine($"Length: {arrNullable?.Length}");

            #endregion

            #region Problem12
            /*
              Problem: Write a program that: 
                    o Asks the user to enter a day of the week. 
                    o Uses a switch expression to map the day to its corresponding number (e.g., "Monday" -> 1). 
             */

            //Console.Write("Enter day: ");
            //string day = Console.ReadLine();
            //int dayNumber = day.ToLower() switch
            //{   
            //    "sunday" => 1,
            //    "monday" => 2,
            //    "tuesday" => 3,
            //    "wednesday" => 4,
            //    "thursday" => 5,
            //    "friday" => 6,
            //    "saturday" => 7,
            //    _ => 0
            //};
            //Console.WriteLine($"Day number: {dayNumber}");

            #endregion

            #region Problem13
            /*
              Problem: Write a method SumArray that: 
                     o Accepts a variable number of integers using the params keyword. 
                     o Returns the sum of the provided integers. 
                     o Demonstrates calling the method with both an array and individual values.
             */

            //int SumArray(params int[] numbers)
            //{
            //    int total = 0;
            //    foreach (int n in numbers)
            //        total += n;
            //    return total;
            //}
            //Console.WriteLine(SumArray(1, 2, 3));
            //Console.WriteLine(SumArray(new int[] { 5, 10, 15 }));

            #endregion



            //Part02

            #region Problem 1
            /*
              Program to Print Numbers in a Range 
                  Write a program that allows the user to insert a positive integer, then print all numbers from 1 to 
                  that number. 
             */

            //int range;
            //while (true)
            //{
            //    Console.Write("Enter a positive integer: ");
            //    if (int.TryParse(Console.ReadLine(), out range) && range > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //for (int i = 1; i <= range; i++)
            //{
            //    Console.Write(i);
            //    if (i < range) Console.Write(", ");
            //}
            //Console.WriteLine();

            #endregion

            #region Problem 2
            /*
             Program to Display Multiplication Table 
                 Write a program that allows the user to insert an integer, then print the multiplication table for 
                 that number up to 12 times. 
             */

            //int numTable;
            //while (true)
            //{
            //    Console.Write("Enter an integer for multiplication table: ");
            //    if (int.TryParse(Console.ReadLine(), out numTable))
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //}

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(numTable * i);
            //    if (i < 12) Console.Write(", ");
            //}
            //Console.WriteLine();

            #endregion

            #region Problem 3
            /*
             Program to List Even Numbers 
                  Write a program that allows the user to insert a number, then print all even numbers between 1 
                  and that number. 
             */

            //int evenLimit;
            //while (true)
            //{
            //    Console.Write("Enter a positive integer: ");
            //    if (int.TryParse(Console.ReadLine(), out evenLimit) && evenLimit > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //for (int i = 2; i <= evenLimit; i += 2)
            //{
            //    Console.Write(i);
            //    if (i < evenLimit - 1) Console.Write(", ");
            //}
            //Console.WriteLine();

            #endregion

            #region Problem 4
            /*
             Program to Compute Exponentiation 
                    Write a program that takes two integers, then prints the result of raising the first number to the 
                    power of the second number. 
             */

            //int baseNum, exponent;
            //while (true)
            //{
            //    Console.Write("Enter base number: ");
            //    if (int.TryParse(Console.ReadLine(), out baseNum))
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //}

            //while (true)
            //{
            //    Console.Write("Enter exponent: ");
            //    if (int.TryParse(Console.ReadLine(), out exponent))
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //}

            //long result = 1;
            //for (int i = 0; i < exponent; i++)
            //    result *= baseNum;

            //Console.WriteLine($"{baseNum}^{exponent} = {result}");

            #endregion

            #region Problem 5
            /*
             Program to Reverse a Text String 
                   Write a program that allows the user to enter a string and then prints the string in reverse order. 
             */

            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();
            //char[] chars = text.ToCharArray();
            //Array.Reverse(chars);
            //Console.WriteLine(new string(chars));

            #endregion

            #region Problem 6
            /*
             Program to Reverse an Integer Value 
                     Write a program that allows the user to enter an integer and then prints the integer with its digits 
                     in reverse order.
             */

            //int numRev;
            //while (true)
            //{
            //    Console.Write("Enter an integer: ");
            //    if (int.TryParse(Console.ReadLine(), out numRev))
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //}

            //char[] numChars = numRev.ToString().ToCharArray();
            //Array.Reverse(numChars);
            //Console.WriteLine(new string(numChars));

            #endregion

            #region Problem 7
            /*
             Write a program to find the longest distance between two identical elements in the array. 
                The distance is the count of cells between the two elements. 
             */

            //int size;
            //while (true)
            //{
            //    Console.Write("Enter size of array: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}

            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    while (true)
            //    {
            //        Console.Write($"Enter element {i}: ");
            //        if (int.TryParse(Console.ReadLine(), out arr[i]))
            //            break;
            //        else
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}

            //int maxDistance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //                maxDistance = distance;
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance: {maxDistance}");

            #endregion

            #region Problem 8
            /*
             Program to Reverse Words in a Sentence 
                Given a sentence with space-separated words, write a program to reverse the order of the words. 
             */

            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();
            //string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(words);
            //Console.WriteLine(string.Join(" ", words));

            #endregion


        }
    }
}
