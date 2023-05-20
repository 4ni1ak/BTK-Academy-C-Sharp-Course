using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019._1_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List<string> cities = new List<string>();
            //cities.Add("istanbul");
            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "Tablo");
            dictionary.Add("computer", "bilgisayat");
            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["table"]);

            foreach(string key in dictionary.Keys)
            {
                Console.WriteLine(dictionary[key]);
            }
            var count = dictionary.Count;
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.ReadLine();
        }

        private static void ArrayList()
        {
            //string[] cities = new string[2] { "Ankara", "istanbul" };
            //cities = new string[3];
            //Console.WriteLine(cities[0]);//""
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            Console.WriteLine(cities.Contains("Ankara"));
            foreach (int i in cities)
            {
                Console.WriteLine(i);
            }
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (int i in cities)
            {
                Console.WriteLine(i);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id=20,FirstName="Anıl" });
            customers.Add(new Customer { Id = 2, FirstName = "Akpınar" });
            var count =customers.Count;
            var customer2 = new Customer { Id = 3, FirstName = "Anıla" };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]{
                new Customer { Id = 4,FirstName="Ali" },
                new Customer { Id = 5, FirstName = "Weli" }
            });
            //customers.Clear();
            var index= customers.IndexOf(customer2);
            Console.WriteLine(index);
            customers.Add(customer2);
            var index2 =customers.LastIndexOf(customer2);
            customers.Insert(0, customer2);
            Console.WriteLine(count);

            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");

            Console.WriteLine(index);
            
            foreach (var i in customers)

            {
                Console.WriteLine(i.FirstName);
            }
            Console.WriteLine(count);
            Console.ReadLine();
            
        }
    }
    class Customer
    {
        public int  Id { get; set; }
        public string FirstName { get; set; }
    }
}
