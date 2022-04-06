using Microsoft.EntityFrameworkCore;
using MyTest_eCommerce.Domain.Entidades;
using System.Reflection;

namespace MyTest_eCommerce.Data.Context {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
            => configurationBuilder.Properties<string>()
                                   .AreUnicode(false)
                                   .HaveMaxLength(500);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
