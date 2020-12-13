using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Seller.Models
{
    public class LTWebEntities : DbContext
    {
        public LTWebEntities() : base("LTWebEntities")
        {
        }
        public DbSet<Users> Users { get; set; }
        
        public DbSet<Product> Product { get; set; }

     
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }

}