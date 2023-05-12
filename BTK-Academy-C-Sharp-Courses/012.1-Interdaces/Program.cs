using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012._1_Interdaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterdacesIntro();
            
        }

        private static void InterdacesIntro()
        {
            PersonMenager menager = new PersonMenager(); ;
            //Coustomer coustomer=new Coustomer{ Id = 1, FirstName = "Anıl", LastName = "Akpınar", Adress = "Artvin" };
            //menager.Add(customer);//same
            menager.Add(new Coustomer { Id = 1, FirstName = "Anıl", LastName = "Akpınar", Adress = "Artvin" });
           
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }   
        string LastName { get; set; }
    }
    class Coustomer:IPerson
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress {get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant  { get; set; }
        
    }
    //class PersonMenager
    //{
    //      public void Add(Coustomer coustomer) {
    //      Console.WriteLine(coustomer.FirstName);
    //    }

    //}
    class PersonMenager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
