namespace Restaurant_ManagementFull.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<Restaurant_ManagementFull.DataBase.Context>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(Restaurant_ManagementFull.DataBase.Context context)
    {
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 10, Title = "جنسیت", GourpId = 0 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 20, Title = "نوغ غذا", GourpId = 0 });

      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 101, Title = "آقا", GourpId = 10 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 102, Title = "خانم", GourpId = 10 });

      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 201, Title = "کبابی", GourpId = 20 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 202, Title = "پیتزا", GourpId = 20 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 203, Title = "ساندویچ", GourpId = 20 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 204, Title = "نوشیدنی", GourpId = 20 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 205, Title = "دسر", GourpId = 20 });
      context.LookupTbl.AddOrUpdate(new Models.Lookup { Id = 206, Title = "سرویس", GourpId = 20 });
    }
  }
}
