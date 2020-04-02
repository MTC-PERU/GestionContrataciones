using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MTC.Model;
using MTC.Model.Identity;
using MTC.Persistence.Database.Config;

namespace MTC.Persistence.Database
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UsuarioConfig(modelBuilder.Entity<Usuario>());
            new ApplicationUserConfig(modelBuilder.Entity<ApplicationUser>());
            new ApplicationRoleConfig(modelBuilder.Entity<ApplicationRole>());

        }
    }
}
