using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_Demo.Data
{
    public class Context:IdentityDbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        private void CreateRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name ="Admin",NormalizedName="ADMIN"},
                new IdentityRole() { Name ="User",NormalizedName="User"}
                );

        }
    }
}
