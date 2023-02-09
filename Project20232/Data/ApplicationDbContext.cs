using Project20232.Server.Configurations.Entities;
using Project202322.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;

namespace Project20232.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
        }
    }
}
