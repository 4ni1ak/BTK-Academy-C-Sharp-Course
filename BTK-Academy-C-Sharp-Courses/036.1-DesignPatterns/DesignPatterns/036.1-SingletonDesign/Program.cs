using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _036._1_SingletonDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            //CustomerManager customerManager = new CustomerManager(); it is private u can not acces
            customerManager.Save();
        }
        class CustomerManager
        {
            
            private static CustomerManager _customerManager;
            static object _lockObject  = new object();
            private CustomerManager()
            {

            
            }
            public static CustomerManager CreateAsSingleton()
            {
                lock (_lockObject)
                {
                    if (_customerManager==null)
                    {
                        _customerManager = new CustomerManager();
                    }
                    return _customerManager;
                }
                //return _customerManager ?? (_customerManager = new CustomerManager());
                ////if (_customerManager==null)
                ////{
                ////    _customerManager = new CustomerManager();
                ////}
                ////return _customerManager;
            }
            public  void Save() {
                Console.WriteLine("saved");     
            }

        }
    }
}
