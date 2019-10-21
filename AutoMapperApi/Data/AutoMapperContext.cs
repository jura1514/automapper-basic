using AutoMapperApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperApi.Data
{
    public class AutoMapperContext : DbContext
    {
        public AutoMapperContext(DbContextOptions<AutoMapperContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
