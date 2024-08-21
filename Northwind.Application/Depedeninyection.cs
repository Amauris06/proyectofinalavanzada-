using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Northwind.Application

{
    public static class Depedeninyection
    {

        public static ServiceCollection addinfrastructure(this ServiceCollection services)
        {

            services.addDbcontext();
            return services;

        }

    }
}
