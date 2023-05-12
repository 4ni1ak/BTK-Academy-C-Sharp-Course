using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Strings
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            Intro();
            string sentence = "My name is Anıl Akpınar";
            var result = sentence.Length;
            var result2=sentence.Clone();
            sentence = "My name is Kemal Akpınar";
            Console.WriteLine(sentence);
            Console.WriteLine(result2);
            bool result3= sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result5);
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result6);
            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);
            var result9 = sentence.Substring(3);
            Console.WriteLine(result9);
            result9 = sentence.Substring(3,4);
            Console.WriteLine(result9);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            var result13 = sentence.Remove(3, 4);
            var result14 = sentence.Remove(3);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.ReadLine();
        }
        static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);
            string city2 = "İstanbul";
            //string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
