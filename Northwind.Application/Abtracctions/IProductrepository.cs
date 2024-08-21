using Northwind.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abtracctions
{
    public interface IProductrepository
    {
        IEnumerable<product> Getall();

        void add(product product);

    }
}
