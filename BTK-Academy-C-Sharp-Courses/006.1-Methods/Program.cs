using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _6._1_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(); // Call Add method five times
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30); // Call Add2 method with two arguments and store the result in the variable named "result"
            Console.WriteLine(result); // Print the value of "result" variable to the console
            var result2 = Add3(); // Call Add3 method with no arguments and store the result in the variable named "result2"
            Console.WriteLine(result2); // Print the value of "result2" variable to the console
            int number1 = 10; // Declare and initialize the "number1" variable with the value of 10
            var result3 = Add4(ref number1, 50); // Call Add4 method with two arguments and pass "number1" by reference, then store the result in the variable named "result3"
            Console.WriteLine(result3); // Print the value of "result3" variable to the console
            int number2; // Declare the "number2" variable
            var result4 = Add5(out number2, 50); // Call Add5 method with two arguments and pass "number2" by reference, then store the result in the variable named "result4"
            Console.WriteLine(result4); // Print the value of "result4" variable to the console
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,4));//Methods overloding
            Console.WriteLine(Sum(1,23,232,6,565,646,45,6));
        }

        // A method that prints "Added!" five times to the console
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        // A method that takes two integers as arguments and returns their sum
        static int Add2(int x, int y)
        {
            return x + y;
        }

        // A method that has two parameters with default values and returns their sum. If no value is assigned to the parameter, it adds up to 6.
        static int Add3(int x = 1, int y = 5)
        {
            return x + y;
        }

        // A method that takes the first parameter by reference and has a second parameter with a default value. It sets the value of the first parameter to 30 and returns the sum of the two parameters.
        static int Add4(ref int x, int y = 30)//
        {
            x = 30;
            return x + y;
        }
        static int Add5(out int x, int y = 30)//
        {
            x = 30;
            return x + y;
        }
        static int Multiply( int x, int y)
        {
           
            return x * y;
        }
        static int Multiply(int x, int y,int z)
        {

            return x * y * z;
        }
        static int Sum(int number, params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}