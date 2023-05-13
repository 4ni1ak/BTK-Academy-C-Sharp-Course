using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013._1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Coustomer{FirstName="Anıl"},
                new Student{FirstName= "Kemal"},
                new Person{FirstName="Ali"}
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
        }
        class Coustomer : Person
        {
            public string City {get; set; }
        }
        class Student : Person
        {
            public string Department {get; set; }
        }
    }
}
