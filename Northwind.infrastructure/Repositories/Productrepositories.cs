using Northwind.Application.Abtracctions;
using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.infrastructure.Repositories
{
    internal class Productrepositories : IProductrepository
    {
        private readonly NorthwindDbcontext _Dbcontext;

        public Productrepositories() 
        
        {
        
        }

        public void add(product product)
        {
            _Dbcontext.products.Add(product);
        }

        public IEnumerable<product> Getall()
        {
            return _Dbcontext.products.ToList();
        }
    }
}
