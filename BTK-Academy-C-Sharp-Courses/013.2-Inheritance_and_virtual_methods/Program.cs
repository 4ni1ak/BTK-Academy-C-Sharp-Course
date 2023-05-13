using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013._2_Inheritance_and_virtual_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }
    class Database
    {
        public  virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
            Console.WriteLine("You can not do this in Interfaces");
        }
    }
    class MySql : Database
    {

    }
}
