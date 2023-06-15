using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036._5_AbractFactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager =new ProductManager(new Factory1() );
            productManager.GetAll();
            Console.ReadLine();
        }
    }
    public abstract class Logging
    {
        public abstract void Log(string message);
        
    }
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");

        }
    }
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with NLogger");

        }
    }
    public abstract class Caching
    {

        public abstract void Cache(string data);

    }
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Caching with MemCache");
        }
    }
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Caching with Redis");
        }
    }
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return  new Log4NetLogger();
        }
    }
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }
    public class ProductManager: IProductManager

    {
        private Logging _logging;
        private Caching _caching;
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _caching = _crossCuttingConcernsFactory.CreateCaching();
            _logging = _crossCuttingConcernsFactory.CreateLogger();
        }

        public void GetAll()
        {
            //_crossCuttingConcernsFactory.CreateLogger().Log();
            _logging.Log("logg");
            _caching.Cache("data");
            Console.WriteLine("Products listed!");

        }
    }

    public interface IProductManager
    {
    }
}
