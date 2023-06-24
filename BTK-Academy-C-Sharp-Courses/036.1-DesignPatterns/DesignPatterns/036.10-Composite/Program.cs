using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036._10_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee anıl = new Employee {Name="Anıl Akpınar" };
            Employee ece = new Employee { Name = "Ece Güngör" };
            anıl.AddSubordinate(ece);
            Employee fatma = new Employee { Name = "Fatma Yılaz" };
            ece.AddSubordinate(fatma);
            foreach (Employee manager in anıl)
            {
                Console.WriteLine(manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine(employee.Name);
                    
                }
                Console.ReadLine();

            }
        }
    }
    interface IPerson 
    {
        string Name { get; set; }
    }
    class Employee:IPerson,IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        
        
        public void  AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string Name { get; set; }
        
    }
    class Contactor: IPerson
    {
        public string Name { get; set; }
    }
}
