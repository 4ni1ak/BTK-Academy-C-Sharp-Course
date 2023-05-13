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
            throw new NotImplementedException();

        }
        public void Update()
        {
            throw new NotImplementedException();

        }
        public void Delete()
        {
            throw new NotImplementedException();

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
            throw new NotImplementedException();

        }
        public void Delete()
        {
            throw new NotImplementedException();

        }
    }

    
}
