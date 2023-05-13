using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012._1_Interdaces
{
    interface ICustomerDal//data access layer
    {

        void Add();
        void Update();  
        void Delete();  
    }
        class OracleServerCustomerDal:ICustomerDal
        {
        public void Add()
        {
            Console.WriteLine("Oracle Added ");


        }
        public void Update()
        {
            Console.WriteLine("Oracle Update "); ;

        }
        public void Delete()
        {
            Console.WriteLine("Oracle Delete ");

        }
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added ");

        }
        public void Update()
        {
            Console.WriteLine("Sql Update ");

        }
        public void Delete()
        {
            Console.WriteLine("Sql Delete ");

        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

    
}
