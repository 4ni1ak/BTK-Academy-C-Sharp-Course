using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FuentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        //fluent validation
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();
            RuleFor(p=>p.UnitPrice).NotEmpty();
            RuleFor(p=>p.QuantityPerUnit).NotEmpty(); 
            RuleFor(p=>p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(P => P.CategoryId == 2);//u can remove 
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Product name not start 'A' ");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); 
        }
    }
}
