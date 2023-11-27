using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecityEntityFramework
{
    internal class AppDbContext: DbContext
    {
        public AppDbContext()   {  }

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=onlineshop;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
