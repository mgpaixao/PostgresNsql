using Microsoft.EntityFrameworkCore;
using PostgresNsql.Models;

namespace PostgresNsql
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseNpgsql()
            .UseSnakeCaseNamingConvention();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder
            .Entity<DataModel>()
            .Property(e => e.Id)
            .UseIdentityAlwaysColumn();

        public DbSet<DataModel> DataModels { get; set; }
    }

}
