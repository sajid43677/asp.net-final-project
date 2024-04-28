namespace dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dal.Models.SMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(dal.Models.SMContext context)
        {
            /*for (int i = 1; i <= 10; i++)
            {
                context.Securitys.AddOrUpdate(new Models.Security
                {
                    id = i,
                    name = Guid.NewGuid().ToString().Substring(0, 15),
                    phone = Guid.NewGuid().ToString().Substring(0, 11),
                    password = Guid.NewGuid().ToString().Substring(0, 4),

                });
            }

            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                context.Shifts.AddOrUpdate(new Models.Shift
                {
                    sid = i,
                    position = Guid.NewGuid().ToString().Substring(0, 7),
                    shift = Guid.NewGuid().ToString().Substring(0, 7),
                    secId = i,

                });
            }

            for (int i = 1; i <= 50; i++)
            {
                context.Reports.AddOrUpdate(new Models.Report
                {
                    nid = i,
                    reason = Guid.NewGuid().ToString().Substring(0, 15),
                    carNo = Guid.NewGuid().ToString().Substring(0, 10),
                    secId = random.Next(1, 11)

                }); ;
            }*/
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*for (int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                context.Repairs.AddOrUpdate(new Models.Repair
                {
                    id = i,
                    repairDetails = Guid.NewGuid().ToString().Substring(0, 15),
                    status = Guid.NewGuid().ToString().Substring(0, 7),
                    tid = random.Next(1,11),

                });
                context.Tenants.AddOrUpdate(new Models.Tenant
                {
                    id = i,
                    floorNo = random.Next(1,11),
                    flatNo = Guid.NewGuid().ToString().Substring(0, 7),
                    uid = i,

                });
            }*/
        }
    }
}
