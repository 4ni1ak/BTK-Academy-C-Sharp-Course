using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027._1_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate();
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            myDelegate -= customerManager.ShowAlert;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("Hiiii");
            Maths maths = new Maths();
            MyDelegate3 myDelegate3 = maths.Multiply;
            var result = myDelegate3(2, 3);
            Console.WriteLine(result);
             
            Console.ReadLine();
        }
    }
    public class Maths
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiply(int num1, int num2 )
        {
            return num1 * num2;

        }
    }
    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hiiii");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }
    }
}
