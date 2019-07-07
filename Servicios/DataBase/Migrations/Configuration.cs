using Dominio;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Servicios.DataBase.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Servicios.Db.AppDbContext";
        }
        protected override void Seed(AppDataBaseContext db)
        {
            #region Items
            if (db.Items.Any())
                return;

            db.Items.AddOrUpdate(new Item() { nombre = "Coca-Cola", precio = 10 });

            db.SaveChanges();
            var item1 = db.Items.FirstOrDefault(x => x.nombre == "Coca-Cola");

            #endregion
        }

    }
}
