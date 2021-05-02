using EskApiPersonalFinance.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EskApiPersonalFinance.Infra.Data.EntityConfig
{
    class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
            HasKey(a => a.AccountId);

            Property(a => a.Agency)
                .IsRequired()
                .HasMaxLength(10);

            Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(25);

            Property(a => a.Balance)
                .IsRequired();

            HasRequired(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId);
        }
    }
}
