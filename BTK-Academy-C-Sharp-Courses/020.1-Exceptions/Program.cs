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
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            HandleException(() =>
            {
                Find();
            });

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
