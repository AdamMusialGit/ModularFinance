using Microsoft.EntityFrameworkCore;
using Module.Auth.Core.Abstractions;
using Shared.Infrastucture.Persistance;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Threading;
using Module.Auth.Core.Entities;

namespace Module.Auth.Infrastructure.Persistance
{
    internal class AuthDbContext : IdentityDbContext<ApplicationUser>, IAuthDbContext
    {
        protected string Schema => "Account";
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (!string.IsNullOrWhiteSpace(Schema))
            {
                modelBuilder.HasDefaultSchema(Schema);
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return (await base.SaveChangesAsync(true, cancellationToken));
        }
    }
}
