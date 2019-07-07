using Dominio;
using System.ComponentModel.DataAnnotations.Schema;
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
        public IDbSet<Categoria> Categorias { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            #region Items
            modelBuilder.Entity<Item>().ToTable("Items","dbo").HasKey(item => item.Id);
            modelBuilder.Entity<Item>().Property(item => item.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Item>().Property(item => item.Nombre).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Item>().Property(item => item.Precio).IsRequired();
            modelBuilder.Entity<Item>().HasRequired(item => item.Categoria).WithMany(categoria => categoria.Items);
            #endregion
            #region Categorias
            modelBuilder.Entity<Categoria>().ToTable("Categorias").HasKey(categoria => categoria.Id);
            modelBuilder.Entity<Categoria>().Property(categoria => categoria.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Categoria>().Property(categoria => categoria.Descripcion).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Categoria>().HasMany(categoria => categoria.Items).WithRequired(item => item.Categoria).Map(m => m.MapKey("CategoriaId"));
            #endregion
        }
    }
}