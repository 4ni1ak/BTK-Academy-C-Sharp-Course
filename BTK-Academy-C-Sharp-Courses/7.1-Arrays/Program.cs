using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Anıl";
            string student2 = "Halim";
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            string[] students = new string[3];
            students[0] = "Anıl";
            students[1] = "Veli";
            students[2] = "Halis";
            foreach (var s in students) {
                Console.WriteLine(s);
            };
            Console.WriteLine();
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };
            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j=0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadLine();


        }
    }
}
