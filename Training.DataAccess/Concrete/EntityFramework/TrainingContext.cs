using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class TrainingContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB;initial catalog=Northwind;integrated security=true");

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
