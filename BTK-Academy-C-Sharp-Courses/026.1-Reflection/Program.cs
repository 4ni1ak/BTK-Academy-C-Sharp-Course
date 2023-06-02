using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _026._1_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FourTransactions fourTransactions = new FourTransactions(2, 3);
            //fourTransactions.Addition();
            //fourTransactions.Multiplication();
            //fourTransactions.Multiplication2(2, 6);
            //fourTransactions.Addition2(2, 6);
            var type =typeof(FourTransactions);
            //Console.WriteLine( fourTransactions.Addition());
            //Console.WriteLine( fourTransactions.Addition2(2, 3));
            //Console.ReadLine();
            var instance = (FourTransactions)Activator.CreateInstance(type, 4, 8);
            MethodInfo methodInfo = instance.GetType().GetMethod("Addition");
            Console.WriteLine( methodInfo.Invoke(instance,null));
            Console.WriteLine("------------------------");
            var methods=type.GetMethods();
            foreach (var info in methods)
            {
            Console.WriteLine("Methods Name ==> {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter ==> {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes()) 
                {
                    Console.WriteLine("Attribute Name {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    } 
    public class FourTransactions
    {
        private int _number1, _number2;
        public FourTransactions(int number1,int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Multiplication() 
        {
            return _number1 * _number2;
        }

        public int Addition()
        {
            return _number1+_number2;
        }
        public int Multiplication2(int number1,int number2)
        {
            return number1 * number2;
        }
        [MerhodName("Addiction")]
        public int Addition2(int number1, int number2)
        {
            return number1 + number2;
        }

    }
    class MerhodNameAttribute : Attribute
    {
        public MerhodNameAttribute(string name)
        {
        
        }
    }
}
