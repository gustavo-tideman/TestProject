using System.Linq;
using Microsoft.EntityFrameworkCore;
using UnitTest.Data.Mappings;
using UnitTest.Data.Model;

namespace UnitTest.Data.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            modelBuilder.ApplyConfiguration(new ClienteMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}