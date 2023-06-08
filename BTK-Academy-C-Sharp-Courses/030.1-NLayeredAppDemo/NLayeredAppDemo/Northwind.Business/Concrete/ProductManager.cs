using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager :IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal) 
        {
            _productDal = productDal;        
        }
        public List<Product> GetAll()
        {
            
            return _productDal.GetAll();
        }

    }
}
