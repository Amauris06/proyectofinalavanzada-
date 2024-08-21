using Microsoft.EntityFrameworkCore;
using Northwind.Domain;

namespace Northwind.infrastructure
{
    public class NorthwindDbcontext : DbContext
    {

        public DbSet<product> products {get; set;}
        public NorthwindDbcontext(DbContextOptions<NorthwindDbcontext> options): base (options)
        { 
        
        }
    }
}
