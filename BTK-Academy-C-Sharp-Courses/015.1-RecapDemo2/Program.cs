﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015._1_RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger=new DatabaseLogger();
            customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();



            Console.ReadLine();
        }
      
    }
    class CustomerManager
    {
        public ILogger Logger { get;  set; }
        public void Add()
        {
            
            Logger.Log();

            Console.WriteLine("Customer added!");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");

        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");

        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");

        }
    }
    interface ILogger
    {
        void Log(); 
    }
}
