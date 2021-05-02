using EskApiPersonalFinance.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EskApiPersonalFinance.Infra.Data.EntityConfig
{
    class LaunchConfiguration : EntityTypeConfiguration<Launch>
    {
        public LaunchConfiguration()
        {
            HasKey(l => l.LaunchId);

            Property(l => l.Value)
                .IsRequired();

            HasRequired(l => l.Account)
                .WithMany()
                .HasForeignKey(l => l.AccountId);
        }
    }
}
