using System;
using System.ComponentModel;
using System.Text;

namespace D3TaskC_
{

    class Name
    {
        public string Name1;
    }


    internal class Program
    {

        static void Main()
        {


            #region Problem1

            /* 
                 Problem: Write a program to: 
                  o Accept a string input from the user.
                  o Convert it to an integer using both int.Parse and Convert.ToInt32.
                  o Handle potential exceptions using a try-catch block.
            */

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();
            //// Using int.Parse
            //try
            //{
            //    int number1 = int.Parse(input);
            //    Console.WriteLine("Using int.Parse: " + number1);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("int.Parse: The input is not a valid integer format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("int.Parse: The number is too large or too small for an Int32.");
            //}

            //// Using Convert.ToInt32
            //try
            //{
            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine("Using Convert.ToInt32: " + number2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Convert.ToInt32: The input is not a valid integer format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Convert.ToInt32: The number is too large or too small for an Int32.");
            //}

            #endregion

            #region Problem2
            /*
              Problem: Write a program that: 
                      o Prompts the user to input a number. 
                      o Uses int.TryParse to check if the input is a valid integer. 
                      o If valid, print the number; otherwise, print an error message. 
            */

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //// Try to parse the input
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("You entered a valid number: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            //}


            #endregion

            #region Problem3
            /*
              Problem: Implement a program to: 
                     o Declare an object variable. 
                     o Assign it different data types (e.g., int, string, double). 
                     o Print the GetHashCode() of each assignment. 
             */

            //object O1;

            //// Assign int
            //O1 = 42;
            //Console.WriteLine("Int assignment");
            //Console.WriteLine("Value: " + O1);
            //Console.WriteLine("GetHashCode: " + O1.GetHashCode() + "\n");

            //// Assign string
            //O1 = "Hello";
            //Console.WriteLine("String assignment");
            //Console.WriteLine("Value: " + O1);
            //Console.WriteLine("GetHashCode: " + O1.GetHashCode()+"\n");

            //// Assign double
            //O1 = 3.14;
            //Console.WriteLine("Double assignment");
            //Console.WriteLine("Value: " + O1);
            //Console.WriteLine("GetHashCode: " + O1.GetHashCode()+"\n");

            #endregion

            #region Problem4
            /*
             Problem: Demonstrate how changing one reference affects another when both point to the same object.
                    Use the following steps: 
                   o Create an object and assign it a value. 
                   o Create a second reference to the same object. 
                   o Modify the value of the object using one reference and print the value using the 
                   other.
            */
            //// Step 1: Create an object and assign a value
            //Name n1 = new Name();
            //n1.Name1 = "Ali";

            //// Step 2: Create a second reference to the same object
            //Name n2 = n1;

            //// Step 3: Modify the value using one reference
            //n2.Name1 = "Ahmed";

            //Console.WriteLine("person1.Name: " + n1.Name1); 
            //Console.WriteLine("person2.Name: " + n2.Name1);

            #endregion

            #region Problem5
            /*
             Problem: Write a program to: 
                   o Declare a string and modify it by concatenating additional text “Hi Willy”. 
                   o Print the GetHashCode() before and after modification. 
             */

            //// Declare original string
            //string message = "Hello, ";
            //Console.WriteLine("Original string: " + message);
            //Console.WriteLine("Original GetHashCode: " + message.GetHashCode());

            //// Modify string by concatenation
            //message += "Hi Ali";
            //Console.WriteLine("\nModified string: " + message);
            //Console.WriteLine("Modified GetHashCode: " + message.GetHashCode());

            #endregion

            #region Problem6
            /*
             Problem: Create a program to: 
                    o Use StringBuilder to append text to a string “Hi Willy”. 
                    o Print the GetHashCode() of the StringBuilder instance before and after the 
                    modification. 
             */

            //// Create a StringBuilder with initial text
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine("Original content: " + sb);
            //Console.WriteLine("Original GetHashCode: " + sb.GetHashCode());

            //// Append text
            //sb.Append(",Hi Ali");
            //Console.WriteLine("\nModified content: " + sb);
            //Console.WriteLine("Modified GetHashCode: " + sb.GetHashCode());

            #endregion

            #region Problem7
            /*
              Problem: Create a program to: 
                     o Accept two integer inputs from the user. 
                     o Display the sum using all three methods “Sum is input1+input2”: 
                      Concatenation (+ operator) 
                      Composite formatting (string.Format) 
                      String interpolation ($)  
             */

            ////first integer input
            //Console.Write("Enter first number: ");
            //int input1 = int.Parse(Console.ReadLine());
            ////second integer input
            //Console.Write("Enter second number: ");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;

            //// Using concatenation (+ operator)
            //Console.WriteLine("Using concatenation: Sum of " + input1 + "+" + input2 + " = " + sum);

            //// Using composite formatting
            //Console.WriteLine("Using string.Format: {0}+{1} = {2}", input1, input2, sum);

            //// Using string interpolation
            //Console.WriteLine($"Using string interpolation: {input1}+{input2} = {sum}");

            #endregion

            #region Problem8
            /*
             Problem: Create a program using StringBuilder to: 
                     o Append text. 
                     o Replace a substring. 
                     o Insert a string at a specific position. 
                     o Remove a portion of text. 
             */

            //// Initialize StringBuilder with some text
            //StringBuilder sb = new StringBuilder("Hello");
            //// 1. Append text
            //sb.Append(" World");
            //Console.WriteLine("After Append: " + sb);
            //// 2. Replace a substring ("World" with "Willy")
            //sb.Replace("World", "Ali");
            //Console.WriteLine("After Replace: " + sb);
            //// 3. Insert a string at a specific position (insert "Hi, " at index 0)
            //sb.Insert(0, "Hi, ");
            //Console.WriteLine("After Insert: " + sb);
            //// 4. Remove a portion of text (remove "Hi, " → 0 to 4 characters)
            //sb.Remove(0, 4);
            //Console.WriteLine("After Remove: " + sb);

            #endregion

        }
    }
}
