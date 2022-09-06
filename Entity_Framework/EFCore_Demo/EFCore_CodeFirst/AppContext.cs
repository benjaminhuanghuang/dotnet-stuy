using EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst
{
    internal class AppContext: DbContext
    {
        public AppContext()
        {

        }

        public AppContext(DbContextOptions<AppContext> options)
        {

        }

        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"server=BENTKPAD\SQLEXPRESS;database=efcoreDb;trusted_connection=true;MultipleActiveResutlSets=true";
            
            optionsBuilder.UseSqlServer(connString);

        }
    }
}
