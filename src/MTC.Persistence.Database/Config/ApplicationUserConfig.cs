using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTC.Model.Identity;

namespace MTC.Persistence.Database.Config
{
    public class ApplicationUserConfig
    {
        public ApplicationUserConfig(EntityTypeBuilder<ApplicationUser> entityBuilder)
        {
            entityBuilder.Property(e => e.FistName).IsRequired().HasMaxLength(50);
            entityBuilder.Property(e => e.LastName).IsRequired().HasMaxLength(100);

            entityBuilder
                .HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
