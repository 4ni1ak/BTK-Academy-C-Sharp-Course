using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036._6_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {FirstName="Anıl",LastName="Akpinar",City="Ankara",Id=1 };
            Console.WriteLine(customer.FirstName);
            var customer2 = (Customer)customer.Clone();
            customer2.FirstName = "Ece";
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class Customer : Person
    {
        public string City{ get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
