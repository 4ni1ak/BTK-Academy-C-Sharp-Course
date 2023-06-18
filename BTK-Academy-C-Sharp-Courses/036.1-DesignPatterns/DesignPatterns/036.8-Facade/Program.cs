using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036._8_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

    public interface ICaching
    {
        void Cache();
    }

    public interface ILogging
    {
        void Log();
    }

    public interface IAuthorize
    {
        void CheckUser();
    }

    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Check User");
        }
    }

    class CustomerManager
    {
        private CrossCuttingConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Logging.Log();
            _concerns.Authorize.CheckUser();
            Console.WriteLine("Save");
        }
    }

    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }

}
