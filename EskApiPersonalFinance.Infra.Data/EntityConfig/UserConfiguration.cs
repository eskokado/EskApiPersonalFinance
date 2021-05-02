using EskApiPersonalFinance.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EskApiPersonalFinance.Infra.Data.EntityConfig
{
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);

            Property(u => u.Username)
                .IsRequired();

            Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Email)
                .IsRequired();
        }
    }
}
