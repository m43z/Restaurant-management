using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Restaurant_ManagementFull.Models;

namespace Restaurant_ManagementFull.DataBase
{
  public class Context : DbContext
  {
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Food>().HasRequired(F => F.TypeFood).WithMany().WillCascadeOnDelete(false);

      modelBuilder.Entity<Customer>().HasRequired(C => C.Gender).WithMany().WillCascadeOnDelete(false);
    }

    public Context() : base("dbRes") { }

    public DbSet<Customer> CustomerTbl { get; set; }
    public DbSet<Invoice> InvoiceTbl { get; set; }
    public DbSet<InvoiceDetails> InvoiceDetailsTbl { get; set; }
    public DbSet<Food> FoodTbl { get; set; }
    public DbSet<Lookup> LookupTbl { get; set; }
  }
}
