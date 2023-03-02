using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class GbpConfiguration : IEntityTypeConfiguration<GbpEntity>
	{
		public void Configure(EntityTypeBuilder<GbpEntity> builder)
		{
			builder
				.ToTable("GBP")
				.HasKey(currency => currency.Id);
			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(curency => curency.Gbp)
				.HasForeignKey<GbpEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
