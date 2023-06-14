using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036._04_FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerMamager customerMamager = new CustomerMamager(new LoggerFactory2());
            customerMamager.Save();
            Console.ReadLine();
        }
    }
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Bussiness to decide factory
            return new AnLogger();
        }
    }
    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Bussiness to decide factory
            return new Log4NetLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {

        void Log();
    }
    public class AnLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with AnLogger");

        }
    }
    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4NetLogger");

        }
    }
    public class CustomerMamager
    {
        private ILoggerFactory _loggerFactory;
        public CustomerMamager(ILoggerFactory loggerFactory)
        {
                _loggerFactory = loggerFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
            ILogger logger =_loggerFactory.CreateLogger();// now u are ot addict //new AnLogger(); //you are now addicted to this object
            logger.Log();
        }
    }
    
}
