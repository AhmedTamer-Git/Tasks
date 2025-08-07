using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace D4TaskC_
{
    internal class Program
    {
        enum DayOfWeek
        {   
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday          
        }


        static void Main()
        {
            ////Part01

            #region Problem1
            /*
             Problem: Write a program that: 
                    o Initializes a one-dimensional array in three different ways(new int[size],
                    initializer list, and Array syntax sugar).
                    o Assigns values to each element in the array and prints them.
                    o Demonstrates an IndexOutOfRangeException. 
            */

            //// 1
            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //Console.WriteLine("Array 1 (new int[size]):");

            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}

            //// 2
            //int[] arr2 = new int[] { 40, 50, 60 };

            //Console.WriteLine("\nArray 2 (initializer list):");

            //foreach (int num in arr2)
            //{
            //    Console.WriteLine(num);
            //}

            //// 3
            //int[] arr3 = { 70, 80, 90 };

            //Console.WriteLine("\nArray 3 (syntax sugar):");

            //foreach (int num in arr3)
            //{
            //    Console.WriteLine(num);
            //}

            //// 4
            //Console.WriteLine("\nTrying to access invalid index:");
            //try
            //{
            //    Console.WriteLine(arr1[3]); // Index غير موجود → هيرمي استثناء
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("❌ Exception caught: " + ex.Message);
            //}

            #endregion

            #region Problem2
            /*
             Problem: Write a program to: 
                     o Create two arrays (arr1 and arr2). 
                     o Perform a shallow copy and demonstrate how modifying one affects the other. 
                     o Perform a deep copy using the Clone method and show that modifications do not 
                     affect the copied array.
             */

            //int[] arr1 = { 1, 2, 3 };

            //int[] arr2 = arr1;

            //arr2[0] = 99;

            //Console.WriteLine(" After shallow copy and modifying arr2:");
            //Console.WriteLine("arr1[0]: " + arr1[0]); 
            //Console.WriteLine("arr2[0]: " + arr2[0]);

            //int[] arr3 = (int[])arr1.Clone();

            //arr3[1] = 77;

            //Console.WriteLine("\n After deep copy and modifying arr3:");
            //Console.WriteLine("arr1[1]: " + arr1[1]); 
            //Console.WriteLine("arr3[1]: " + arr3[1]);

            #endregion

            #region Problem3
            /*
              Problem: Write a program to: 
                    o Create a 2D array with student grades (3 students, 3 subjects each). 
                    o Take input from the user to fill the array. 
                    o Print the grades for each student using nested loops.
             */

            //int[,] grades = new int[3, 3]; 

            //for (int stu = 0; stu < grades.GetLength(0); stu++)
            //{
            //    Console.WriteLine($"\nEnter grades for Student {stu + 1}:\n");

            //    for (int sub = 0; sub < grades.GetLength(1);)
            //    {
            //        Console.Write($"Subject {sub + 1}: ");
            //        bool flag = int.TryParse(Console.ReadLine(), out grades[stu, sub]);
            //        if (flag && grades[stu, sub] <= 100 && grades[stu, sub] >= 0)
            //            sub++;

            //    }
            //}
            //Console.Clear();

            //Console.WriteLine("\nStudents Grades:\n");

            //for (int stu = 0; stu < grades.GetLength(0); stu++)
            //{
            //    Console.Write($"Student {stu + 1}: \n");

            //    for (int sub = 0; sub < grades.GetLength(1); sub++)
            //    {
            //        Console.Write($"grade of sub { sub + 1} is { grades[stu, sub]}" + " \n");
            //    }
            //}

            #endregion

            #region Problem4
            /*
              Problem: Write a program that: 
                    o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear). 
                    o Explains the changes before and after applying each method.
             */

            //int[] numbers = { 5, 2, 4, 1, 3 };

            //Console.WriteLine("Original Array:\n");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //// Sort
            //Array.Sort(numbers);
            //Console.WriteLine("\n\nAfter Sort (Ascending):\n");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //// Reverse
            //Array.Reverse(numbers);
            //Console.WriteLine("\n\nAfter Reverse (Descending):\n");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //// IndexOf
            //int index = Array.IndexOf(numbers, 2);
            //Console.WriteLine($"\n\nIndex of : {index}");

            //// Copy
            //int[] copyArr = new int[numbers.Length];

            //Array.Copy(numbers, copyArr, numbers.Length);
            //Console.WriteLine("\nCopied Array:\n");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //// Clear
            //Array.Clear(numbers, 1, 2); 
            //Console.WriteLine("\n\nAfter Clear (set elements in index 1 and 2 to 0):\n");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine();

            #endregion

            #region Problem5
            /*
             Problem: Create a program that: 
                    o Uses a for loop to print all elements of a 1D array. 
                    o Uses a foreach loop to print all elements of the same array. 
                    o Uses a while loop to print all elements in reverse order. 
             */

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// for loop
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //// foreach loop
            //Console.WriteLine("\n\nUsing foreach loop:");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //// while loop 
            //Console.WriteLine("\n\nUsing while loop (reverse order):");
            //int j = numbers.Length - 1;
            //while (j >= 0)
            //{
            //    Console.Write(numbers[j] + " ");
            //    j--;
            //}

            //Console.WriteLine();

            #endregion

            #region Problem6
            /*
              Problem: Write a program that: 
                  o Repeatedly asks the user for a positive odd number. 
                  o Uses defensive coding to validate input using int.TryParse and a do-while 
                  loop. 
             */

            //int number;
            //bool flag;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");

            //    flag = int.TryParse(Console.ReadLine(), out number);

            //} while (!flag || number <= 0 || number % 2 == 0);

            //Console.WriteLine($"\nThank you! \nYou entered: {number}");

            #endregion

            #region Problem7
            /*
             Problem: Write a program to: 
                   o Create a 2D array with fixed values. 
                   o Print the array elements in a matrix format (rows and columns).  
             */

            //int[,] matrix = {
            //{ 1, 2, 3 },
            //{ 4, 5, 6 },
            //{ 7, 8, 9 }
            //};

            //Console.WriteLine("2D Array in Matrix Format:\n");

            //for (int row = 0; row < matrix.GetLength(0); row++) // Rows
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++) // Columns
            //    {
            //        Console.Write(matrix[row, col] + "\t"); // tab للفصل بين الأعمدة
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem8
            /*
              Problem: Write a program that: 
                    o Asks the user to enter a month number. 
                    o Uses an if-else statement to determine the month name. 
                    o Uses a switch statement to perform the same task. 
             */

            //// if-else

            //Console.WriteLine("Using if-else:");
            //Console.Write("Enter month number(1 - 12): ");

            //int month;
            //bool flag = int.TryParse(Console.ReadLine(), out month);

            //if (month == 1)
            //    Console.WriteLine("January");
            //else if (month == 2)
            //    Console.WriteLine("February");
            //else if (month == 3)
            //    Console.WriteLine("March");
            //else if (month == 4)
            //    Console.WriteLine("April");
            //else if (month == 5)
            //    Console.WriteLine("May");
            //else if (month == 6)
            //    Console.WriteLine("June");
            //else if (month == 7)
            //    Console.WriteLine("July");
            //else if (month == 8)
            //    Console.WriteLine("August");
            //else if (month == 9)
            //    Console.WriteLine("September");
            //else if (month == 10)
            //    Console.WriteLine("October");
            //else if (month == 11)
            //    Console.WriteLine("November");
            //else if (month == 12)
            //    Console.WriteLine("December");
            //else
            //    Console.WriteLine("Invalid month number.");

            //// switch

            //Console.WriteLine("\nUsing switch:");
            //Console.Write("Enter month number(1 - 12): ");

            //int mon;
            //bool fla = int.TryParse(Console.ReadLine(), out mon);

            //switch (mon)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number."); break;
            //}

            #endregion

            #region Problem9
            /*
              Problem: Write a program to: 
                   o Sort an array of integers using Array.Sort(). 
                   o Search for a specific value using Array.IndexOf() and Array.LastIndexOf(). 
             */

            //int[] numbers = { 7, 2, 5, 4, 3, 6, 3, 5, 1, 3 };

            //Console.WriteLine("Original array:");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Array.Sort(numbers);

            //Console.WriteLine("\nAfter Array.Sort():");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Console.Write("\nEnter value to search: ");
            //int value;
            //bool flag = int.TryParse(Console.ReadLine(), out value);

            //if (flag)
            //{
            //    int firstIndex = Array.IndexOf(numbers, value);
            //    int lastIndex = Array.LastIndexOf(numbers, value);

            //    if (firstIndex != -1)
            //    {
            //        Console.WriteLine($"\nFirst occurrence of {value} at index: {firstIndex}");
            //        Console.WriteLine($"Last occurrence of {value} at index: {lastIndex}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nValue not found in the array.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            #endregion

            #region Problem10
            /*
             Problem: Write a program that: 
                   o Creates an array of integers. 
                   o Uses a for loop to calculate and print the sum of all elements. 
                   o Uses a foreach loop to calculate the same sum. 
             */

            //int[] numbers = { 10, 20, 30, 40, 50 };

            ////  for loop
            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop: {sumFor}\n");

            ////  foreach loop
            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine($"Sum using foreach loop: {sumForeach}");

            #endregion

            ////Part02

            #region Problem of part02
            /* Define an enum called DayOfWeek with values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.
               o Write a program that takes an integer input from the user (1-7) and prints the corresponding day using the enum. 
               o Use Enum.Parse to convert an integer to an enum value. 
            */

            //Console.Write("Enter a number (1-7): ");
            //bool flag = int.TryParse(Console.ReadLine(), out int dayNum);

            //if (flag && dayNum >= 1 && dayNum <= 7)
            //{
            //    // تحويل الرقم إلى قيمة Enum
            //    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNum.ToString());

            //    Console.WriteLine($"Day {dayNum} is {day}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            //}

            /*
             3- What happens if the user enters a value outside the range of 1 to 7? 

             It will accept any number even if it is not defined within the Enum itself.
             Thus, the number will be converted to an Enum value but not known within its names.
             
             */

            #endregion



        }
    }
}
