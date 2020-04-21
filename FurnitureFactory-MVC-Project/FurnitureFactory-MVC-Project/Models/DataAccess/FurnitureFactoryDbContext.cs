namespace FurnitureFactory_MVC_Project.Models.DataAccess
{
    using FurnitureFactory_MVC_Project.Models;
    using FurnitureFactory_MVC_Project.Models.ViewModels;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class FurnitureFactoryDbContext : IdentityDbContext
    {
        public FurnitureFactoryDbContext(DbContextOptions<FurnitureFactoryDbContext> options)
            : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Sales { get; set; }

        public DbSet<Representative> Representative { get; set; }

        public DbQuery<OrderReport> OrderReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Query<OrderReport>().ToView("OrderReport");
        }
    }
}
