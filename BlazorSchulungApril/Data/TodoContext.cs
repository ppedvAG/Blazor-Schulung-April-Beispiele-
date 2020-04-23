using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class TodoContext:DbContext
    {
        public DbSet<Aufgabe> Aufgabe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Aufgabendb;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
