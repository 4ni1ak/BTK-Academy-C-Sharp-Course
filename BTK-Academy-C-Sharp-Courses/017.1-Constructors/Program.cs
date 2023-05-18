using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _017._1_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.Add();
            Product product = new Product {Id = 1, Name = "Anıl" };
            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.Logger =new DatabaseLogger();
            employeeManager.Logger = new FileLogger();
            employeeManager.Add();
            EmployeeManager employeeManager2 = new EmployeeManager(new DatabaseLogger());
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Teacher.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;

            
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("listed {0} items", _count);

        }
        public void Add() {
            Console.WriteLine("Added");

        }
        
    }
    class Product
    {  
        private string _id;
        private string _name;
        public Product()
        {

        }
        public Product(string id, string name)
        {
            _id = id;
            _name = name;
        }


        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager()
        {

        }
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
            
        }

        public ILogger Logger { get; set; }
        public void Add()
        {   
            Logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Massage()
        {
            Console.WriteLine("{0}",_entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
                       
        }
       public void Add()
        {
            Console.WriteLine("Added");
            Massage();
        }
    }
    static class Teacher
    {
        public static int Number{ get; set; }

    }
    static class Utilities
    {   
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("ValidationEventArgs is done");

        }
    }
    class Manager{
        public static void DoSomething()
        {
            Console.WriteLine("Done");

        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");

        }


    }
}
