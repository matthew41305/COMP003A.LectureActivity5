/*
 * Author: Matthew Hudson
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 5
 * 
 */

using System.ComponentModel;

namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50,'*'));
            Console.WriteLine("Methods & XML Comments");
            Console.WriteLine("".PadRight(50,'*'));
            Console.WriteLine("\n");

            HelloWorld(); // call to HelloWorld()
            HelloWorld("Grace Hopper"); // call to HelloWorld (string name)
            HelloWorld("Donald Knuth"); // call to HelloWorld (string name) again with a different parameter value
            HelloWorld("Alan Turing", DateTime.Now.Year - 1912); // call to HelloWorld(string name, int inputAge), which is an overloaded method
            HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815); // call to HelloWorld(string name, int inputAge) again
            HelloWorld("Charles Babbage", DateTime.Now.Year - 1791); //call to HelloWorld(string name, int inputAge) again

            Console.WriteLine("\n");
            Console.Write("Enter value for inputNumber1: ");
            decimal inputNumber1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter a value for inputNumber2: ");
            decimal inputNumber2 = Convert.ToDecimal(Console.ReadLine());

            // call to Sum(deciaml num1, decimal num2) and storing the reurn value in a variable
            decimal sum = Add(inputNumber1, inputNumber2);
            Console.WriteLine($"Summation: {sum}"); // output the value of sum to console

            //if you don't plan on using a variable, you can simplifiy the mothod call like the lines below
            Console.WriteLine($"Subtraction: {Subtract(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Multiplication: {Multiply(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Division: {Divide(inputNumber1, inputNumber2)}");
            Console.WriteLine($"Remainder: {Remainder(inputNumber1, inputNumber2)}");

            // methods can call other methods too
            // below is an example of a method calling itself, also known as a recursion
            Console.WriteLine("\n");
            Inception("This is inception level", 5);
        } // main close (separates from the bottom of cod ethat has methods)

        /* XML comments are prefixed with three forward slashes '///'
         * if you type '///' on top of a class or a method,
         * visual studio will populate the strcutre for you
         * otherweise, you would have to use the followign opening AND closing tags (similar to most html elements)
         * <summary></summary> used to describe a type member
         * <param name="nameOfTheParameter"></param> used for describing one or more parameters in the method signature
         * <returns></returns> used to describe the return value
         * 
         * there are other tags in
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
         */

        //NOTE: Method definitions are programmed inside the class { } code block, not insidie Main() { }
        /// <summary>
        /// Method without paramters and return value
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        /// <summary>
        /// Method overloading with one parameter buyt no return value
        /// Method overloading => same method name but different signature (different parameters)
        /// </summary>
        /// <param name="inputName">String input</param>
        /// <param name="inputAge">Interger input</param>
        static void HelloWorld(string inputName)
        {
        Console.WriteLine($"Hello, {inputName}");
        // you can add more code here
        }

        ///<summmary>
        ///Method overloading with multiple paramters but no return value
        /// </summmary>
        /// <param name="inputName">String input</param>
        /// <param name="inputAge">Integer input</param>
        static void HelloWorld(string inputName, int inputAge)
        {
            Console.WriteLine($"Hello, {inputName}, age {inputAge}");
            // you can add more code here
        }

        /// <summary>
        /// Method for adding two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Sum of two decimal inputs</returns>
        static decimal Add(decimal num1, decimal num2)
        {
            // you can add more code here before the return statement
            return num1 + num2;
        }
        /// <summary>
        /// Method for subtraction two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Differnce of two deciaml inputs</returns>
        static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Method for multiplying two numeric varaibles
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Product of two decimal inputs</returns>
        static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Method for dividing two numeric variables
        /// </summary>
        /// <param name="num1">Decimal input</param>
        /// <param name="num2">Deciaml input</param>
        /// <returns>Quotient of two deciaml inputs</returns>
        static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        /// <summary>
        /// Method for getting the remainder after dividing two numeric variables
        /// </summary>
        /// <param name="num1">Deciaml input</param>
        /// <param name="num2">Decimal input</param>
        /// <returns>Remainder after dividing two decimal nputs</returns>
        static decimal Remainder(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
        /// <summary>
        /// Recursive method
        /// </summary>
        /// <param name="message">String input to print to console</param>
        /// <param name="counter">Integer input used as a looping counter</param>
        static void Inception(string message, int counter)
        {
            Console.WriteLine($"{message} {counter}");
            counter--;
            if (counter >= 0) Inception(message, counter);
        }
     }
  }

