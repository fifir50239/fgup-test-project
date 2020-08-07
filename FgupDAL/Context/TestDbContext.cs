using FgupDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FgupDAL.Context.Implementation
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<FederalDistrict> FederalDistricts { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }

}
