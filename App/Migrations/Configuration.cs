namespace App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<App.model.democontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(App.model.democontext context)
        {
            for(int i = 0; i < 14; i++)
            {
                context.sinhVIens.AddOrUpdate(new model.SinhVIen 
                    {
                        id = "1" + i.ToString(),
                        hoten = "Minh" + i.ToString(),
                        ngaysinh = DateTime.Now ,
                        gioitinh = true
                    });
            }
                context.cntts.AddOrUpdate(new model.cntt
                {
                    idsv="10",
                    pascal=10,
                    csap=8,
                    sql=9
                });
            context.vans.AddOrUpdate(new model.van
            {
                idsv = "10",
                vhcd = 10,
                vhhh = 8
            });
            context.vatlies.AddOrUpdate(new model.vatly
            {
                idsv = "10",
                cohoc=6,
                dien=7,
                quanhoc=9,
                vlhatnhan=10
            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
