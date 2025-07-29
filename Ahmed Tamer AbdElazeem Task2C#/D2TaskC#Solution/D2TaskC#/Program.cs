using System;
using System.ComponentModel;
using System.Security.Principal;
using System.Xml.Linq;

namespace D2TaskC_
{
    internal class Program
    {

        class Name1
        {
            public string Name;
        }

        static void Main()
        {

            #region problem1
            /*        Problem: Add both single - line and multi-line comments in the following code segment
                    explaining its purpose:
            */

            //int x = 10;     // create an int variable = 10
            //int y = 20;    // create an int variable = 20
            //int sum = x + y;   //create an int variable = sum of two variables
            //Console.WriteLine(sum);  // print sum


            /*      Question: What is the shortcut to comment and uncomment a selected block of code in Visual
                        Studio? 

                        comm: ctrl + k + c 
                      uncomm: ctrl + k + u

            */
            #endregion

            #region problem2

            /* Problem: Identify and fix the errors in this code snippet: 
            */
            //int x = "10";  // varaible x is int and this value is char
            //console.WriteLine(x + y); //console 'c' is small  and y not declare

            //int x = 10;
            //int y = 30;
            //Console.WriteLine(x + y);


            /*
            Question: Explain the difference between a runtime error and a logical error with examples.

           1- A runtime error occurs while the program is running. It causes the program to crash or stop unexpectedly.
              - The code is syntactically correct But something goes wrong during execution
           Examples:
            int a = 10;
            int b = 0;
            int result = a / b; // Runtime Error: DivideByZeroException

           2-A logical error is when your code runs without crashing, but gives the wrong result due to a mistake in logic.
                 - The program runs But the output is incorrect

            Examples:

            double radius = 3;
            double area = 2 * Math.PI * radius; // Logical Error: This is the formula for circumference, not area

            */

            #endregion

            #region problem3
            /*
            Problem: Declare variables using proper naming conventions to store:
               Your full name.
               Your age. 
               Your monthly salary.
               Whether you are a student.
            */

            //string FullName = "Ahmed Tamer Alsharqawy";
            //int Age = 21;
            //decimal MonthlySalary = 8000;
            //bool Student = true;

            //Console.WriteLine("Your fullname: " + FullName);
            //Console.WriteLine("Your age: " + Age);
            //Console.WriteLine("Your monthly salary: " + MonthlySalary);
            //Console.WriteLine("Are you Student ? "+Student);

            /*            
            Question: Why is it important to follow naming conventions such as PascalCase in C#?

            Improves Readability
           Using standard naming styles makes code easier to read and understand — both for you and others.

            Example:

           public class CustomerAccount { } //  Clear and standard
           public class customeraccount { } //  Harder to read

            */

            #endregion

            #region problem4
            /*
            Problem: Write a program to demonstrate that changing the value of a reference type affects all
              references pointing to that object.
            */


            //Name1 n1 = new Name1();  // Create a new object
            //n1.Name = "Ahmed";

            //Name1 n2 = n1;  // Make n2 reference the same object
            //n2.Name = "Tamer";     // Change the Name using n2

            //Console.WriteLine("n1.Name: " + n1.Name); // Output: Tamer
            //Console.WriteLine("n2.Name: " + n2.Name); // Output: Tamer


            /*
            Question: Explain the difference between value types and reference types in terms of memory allocation.

             1. Value Types
              Examples: int, float, bool, char, struct, enum

             Stored In:  Stack memory (usually)

             How It Works:
              Stores the actual value directly.
              When you assign one value type to another, it makes a copy.
              Each variable works independently

             2. Reference Types
              Examples: class, string, array, object, delegate

             Stored In: The reference is stored on the stack
                        The actual object/data is stored on the heap

             How It Works:
              Stores a reference (address) to the actual object.
              When you assign one reference type to another, they share the same object.
              Changing one reference affects all pointing to it.

             */

            #endregion

            #region problem5
            /*Problem: Create a program that calculates the following using variables x = 15 and y = 4: 
                   o Sum 
                   o Difference 
                   o Product 
                   o Division result 
                   o Remainder
            */

            // double x = 15;
            // double y = 4;

            //double sum = x + y;
            //double difference = x - y;
            //double product = x * y;
            //double division = x / y; 
            //double remainder = x % y;

            // Console.WriteLine("x = " + x + ", y = " + y);
            // Console.WriteLine("Sum: " + sum);
            // Console.WriteLine("Difference: " + difference);
            // Console.WriteLine("Product: " + product);
            // Console.WriteLine("Division Result: " + division);
            // Console.WriteLine("Remainder: " + remainder);
            /*
            Question: What will be the output of the following code? Explain why: 
                int a = 2, b = 7; 
                Console.WriteLine(a % b); 

            In this case: 2 divided by 7 is 0 with a remainder of 2
                          Because 2 is smaller than 7, the division result is 0, and the whole value of a remains as the remainder.

            When a < b, then a % b == a
            Because a can't be divided even once by b, so the remainder is just a.

            */

            #endregion

            #region problem6

            /* 
            Problem: Write a program that checks if a given number is both: 
                   o Greater than 10. 
                   o Even.
            */


            //int number = 20;
            //Console.Write("The number is: " + number + "\n");

            //if (number > 10 && number % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number does NOT meet both conditions.");
            //}

            /*
             Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?
             
            1- && (Logical AND):
               Used with boolean (true/false)
               Short-circuits: skips right side if left is false
              
            Example:
              if (a > 5 && b < 10) { ... }

            2-  & (Bitwise AND):
                Used with integers or booleans
                No short-circuiting: always checks both sides
                
            Bitwise when used with numbers:
               int x = 6 & 3;  // result: 2 
             
            Boolean:
              if (true & false) { ... } // false, both evaluated

             */

            #endregion

            #region problem7

            /*
             Problem: Implement a program that takes a double input from the user and casts it to an int. 
                      Use both implicit and explicit casting, then print the results. 
            */

            //Console.Write("Enter a double value: ");
            //double input = Convert.ToDouble(Console.ReadLine());

            //int explicitCast = (int)(input);     // Explicit casting (manual)


            ////  Implicit casting is NOT allowed from double to int (data loss),

            //Console.WriteLine("\n--- Casting Results ---");
            //Console.WriteLine("Explicit cast (double -> int): " + explicitCast);

            /*
            Question: Why is explicit casting required when converting a double to an int?

                  Explicit casting is required when converting a double to an int because:
                      A double can hold decimal (fractional) values.
                      An int can hold whole numbers only.
                      So, converting from double to int may lead to data loss (the decimal part is removed).

                    That’s why C# forces you to do it manually, to make sure you’re aware of the possible loss.
            */
            #endregion

            #region problem8
            /*
             Problem: Write a program that: (G01 Bonus, G02 mandatory) 
                    o Prompts the user for their age as a string. 
                    o Converts the string to an integer using Parse 
                    o Checks if the age is valid (e.g., greater than 0). 
            */

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());   // Convert using Parse
            //// Check if age is valid
            //if (age > 0)
            //{
            //    Console.WriteLine("Valid age: " + age);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age. Age must be greater than 0.");
            //}

            /*
           Question: What exception might occur if the input is invalid and how can you handle it 

                   If the user enters non-numeric input, using int.Parse(input) will throw a: FormatException
                          This happens because the input cannot be converted to an integer.

                   Use a try-catch block to catch the exception and display a friendly message:
            */
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine(); 
            //try
            //{
            //    int age = int.Parse(input);
            //    if (age > 0)
            //    {
            //        Console.WriteLine("Valid age: " + age);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid age. Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. Please enter a numeric value.");
            //}

            #endregion

            #region problem8
            /*
             Problem: Write a program that demonstrates the difference between prefix and postfix 
                      increment operators using a variable x.
            */
            //int x = 5;
            //Console.WriteLine("Initial x: " + x);
            //// Postfix increment: value is used first, then incremented
            //Console.WriteLine("Postfix (x++): " + (x++));  // prints 5, then x becomes 6
            //// Now x = 6
            //Console.WriteLine("After Postfix, x: " + x);   // prints 6
            //// Prefix increment: value is incremented first, then used
            //Console.WriteLine("Prefix (++x): " + (++x));   // x becomes 7, then prints 7
            //// Final value of x
            //Console.WriteLine("Final x: " + x);            // prints 7

            /*
             Question: Given the code below, what is the value of x after execution? Explain why
            */
            
            //         int x = 5; 
            //          int y = ++x + x++;
            //      Console.WriteLine(y);
            
            /*
              ++x -->> x becomes 6, used as 6
              x++ -->> x is 6, used as 6, then becomes 7
              So: y = 6 + 6 = 12
              Final x = 7 
            */

            #endregion


        }
    }
}
