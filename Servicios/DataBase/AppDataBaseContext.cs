using Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Servicios.DataBase
{
    [DbModelBuilderVersion(DbModelBuilderVersion.Latest)]
    public class AppDataBaseContext : DbContext
    {
        public AppDataBaseContext()
            : base("AppDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDataBaseContext, Migrations.Configuration>());
        }
        #region IDbSet
        public IDbSet<Item> Items { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Items

            modelBuilder.Entity<Item>().ToTable("Items").HasKey(item => item.Id);
            modelBuilder.Entity<Item>().Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //bla bla bla. esto no funciona ni sirve

            modelBuilder.Entity<Item>().Property(item => item.nombre).IsRequired().HasMaxLength(100);

            #endregion
        }

    }
}