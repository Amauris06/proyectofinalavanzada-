using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Abtracctions;
using Northwind.infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.infrastructure
{
    public static class Depedeninyection
    {

        public static ServiceCollection addinfrastructure(this ServiceCollection services)
        {



            services.AddScoped<IProductrepository, Productrepositories>();
            services.AddDbContext<NorthwindDbcontext>(options => {

                options.UseSqlServer("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Trust Server Certificate=True");
            
            
            });

            return services;

        }

    }
}
