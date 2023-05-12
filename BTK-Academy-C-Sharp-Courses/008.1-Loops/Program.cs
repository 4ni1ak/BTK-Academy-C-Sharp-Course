using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Loops
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Forloop();
            Whileloop();
            Dowhileloop();
            Foreachloop();
            int number=6;
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("number {0} is a prime number ", number);

            }
            else
            {
                Console.WriteLine("number {0} is not a prime number ", number);
            }
        
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i=2;i<number-1;i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
            
        }
        static void Foreachloop()
        {
            string[] students = new string[3] { "Anıl", "Ahmet", "Mehmet" };
            foreach(var student in students) {
                Console.WriteLine(student);
            }

        }
        static void Dowhileloop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=11);
            Console.WriteLine("Now number is{0}", number);
        }
        static void Whileloop() {
           int number1 = 100;
            while (number1 >= 0)
            {
                Console.WriteLine(number1);
                number1--;
            }
            
            Console.WriteLine("Now number is{0}",number1);
        }
        static void Forloop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

    }
}
