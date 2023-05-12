using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }
            Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
                case 12:
                    Console.WriteLine("Number is 12");
                    break;
                default: 
                    Console.WriteLine("I dont know the number");
                    break;
             }
            if (number>=0&&number<=100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");

            }
            else if (number > 200 && number < 0)
            {
                Console.WriteLine("Number is less than 0 or grather than 200");
            }

        }
    }
}
