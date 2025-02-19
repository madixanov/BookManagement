using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataBaseLayer.ApplicationFolder
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> Options) :base(Options) 
        {
            
        }  

        public DbSet<Book> Books { get; set; }
    }
}
