using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _022._1_EntityFrameworkDemo
{
    internal class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return  context.Products.ToList();

            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();//if you have a lot of data use this 

            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();

            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min&& p.UnitPrice<=max).ToList();

            }
        }
        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
              var result =context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }

        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product); 
                context.SaveChanges();
            }

        }
        public void Update(Product product)
        {
            
            using (ETradeContext context = new ETradeContext())
            {
                var entity= context.Entry(product);
                entity.State=EntityState.Modified;
                
                context.SaveChanges();
            }

        }
        public void Delete(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
