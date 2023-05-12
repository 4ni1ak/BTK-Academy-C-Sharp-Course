using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductMenager productMenager = new ProductMenager();
            CoustomerManager coustomerManager = new CoustomerManager();
            Coustomer coustomer = new Coustomer();

            coustomerManager.Add();
            coustomerManager.Update();
            coustomerManager.Remove();
            
            
            productMenager.Add();
            productMenager.Update();
            productMenager.Remove();

            coustomer.FirstName = "Anıl";
            coustomer.LastName = "Akpınar";
            coustomer.Id = 08;
            coustomer.City = "Artvin";

            Coustomer coustomer2 = new Coustomer
            {
                City = "Ankara", Id = 1, FirstName = "Kemal"
                    
            };
            Console.WriteLine(coustomer2.FirstName);




            Console.ReadLine();
        }
        

    }
    class ProductMenager 
    {
        public void Add() {
            Console.WriteLine("Product Added!");
        }
        public void Remove() {
            Console.WriteLine("Product Remove!");
        }
        public void Update() {
            Console.WriteLine("Product Update!");
        }
    }
    
}
