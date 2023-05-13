using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014._1_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database();//you can not
            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database2=new Sqlserver();
            database2.Add();
            database2.Delete();

            Console.ReadLine();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");

        }
        public abstract void Delete();
     }
    class Sqlserver: Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by default Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by default Oracle");
        }
    }


}
