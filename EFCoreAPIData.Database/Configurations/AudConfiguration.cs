using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class AudConfiguration : IEntityTypeConfiguration<AudEntity>
	{
		public void Configure(EntityTypeBuilder<AudEntity> builder)
		{
			builder
				.ToTable("AUD")
				.HasKey(currency => currency.Id);

			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(quote => quote.Aud)
				.HasForeignKey<AudEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
