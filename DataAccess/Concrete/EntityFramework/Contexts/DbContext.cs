using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class DbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Db;Trusted_Connection=true");
        }

        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<CustomerContact> CustomerContact { get; set; }
        public DbSet<CustomerDetail> CustomerDetail { get; set; }
        public DbSet<CustomerEducation> CustomerEducation { get; set; }
        public DbSet<CustomerHouse> CustomerHouse { get; set; }
        public DbSet<CustomerIdentity> CustomerIdentity { get; set; }
        public DbSet<CustomerProfession> CustomerProfession { get; set; }
        public DbSet<CustomerReference> CustomerReference { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<Sector> Sector { get; set; }
    }
}