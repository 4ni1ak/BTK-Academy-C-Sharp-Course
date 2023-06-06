using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020._1_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();
            //ActionDemo();
            Console.WriteLine(Sum(3, 8));
            Func<int, int, int> add = Sum;
            Console.WriteLine(add(3, 8));
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Func<int> getRandomNumber2=()=>new Random().Next(1,25);
            Console.WriteLine(getRandomNumber2());


            Console.ReadLine();
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void HandleException(Action action) 
        {
            try
            {
                action.Invoke();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Anıl", "Eda", "Diyar" };
            if (!students.Contains("Özlem"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Anıl", "Eda", "Diyar" };
                students[3] = "Özlem";

                Console.ReadLine();
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException);
                throw;
            }

        }
    }
}
