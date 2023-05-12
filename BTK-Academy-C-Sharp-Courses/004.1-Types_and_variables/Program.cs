using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Types_and_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eyyyyyy yo whats up ");
            var number7 = 10;//10.5M//'A'//"Anıl"
            int number1 = 10;
            long  number2 = 206464653205486461;
            short number3 = 32000;
            byte number4 = 255;
            bool condition1 = false;
            char character1 = 'A';
            string string1 = "Anıl";
            double double1 = 8888.8;
            decimal decimal1 = 10.4M;
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("double1 is {0}", double1);
            Console.WriteLine("decimal1 is {0}", decimal1);
            Console.WriteLine("condition is {0}", condition1);
            Console.WriteLine("character is {0}",  character1);//(int)character1= 65
            Console.WriteLine("string1 is {0}", string1);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);



        }
    }
    enum Days
    {
        Monday=1, Tuesday, Wednesday, Friday, Saturday,Sunday
    }
}
