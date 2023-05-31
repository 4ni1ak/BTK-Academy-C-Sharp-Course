using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _024._1_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities=new Utilities();
            List<string>result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach(string item in result) { 
            Console.WriteLine(item);
            }
            Console.ReadLine();
            List<Customer> return2 = utilities.BuildList<Customer>(new Customer { FirstName="Anil"},new Customer { FirstName="Diyar"});
            foreach(var customer in return2) {
                Console.WriteLine(customer.FirstName);
            }
        }

    }
    class Utilities { 
    public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    
    }
    class Product: IEntity
    {

    }

    interface IRepository<T>where T:class, IEntity, new()//struct only accept variable 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IProductDal : IRepository<Product>
    {
        
    }
    interface IDtudentDal : IRepository<Customer>//<Student>//<string>now work!!
    {

    }
    interface IEntity
    {

    }
    class Student:IEntity
    {

    }
    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    class Customer: IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {

    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
