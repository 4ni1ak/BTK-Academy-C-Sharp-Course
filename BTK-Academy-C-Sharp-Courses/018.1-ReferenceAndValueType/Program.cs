using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _018._1_ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1= 30;
            Console.WriteLine(number2);
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bolu", "Bursa", "Balıkesir" };
            cities2 = cities1;
            Console.WriteLine(cities2);

            //DataTable dataTable = new DataTable();
            //DataTable dataTable2 = new DataTable();
            //dataTable2= dataTable;
            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;
        }
    }
}
