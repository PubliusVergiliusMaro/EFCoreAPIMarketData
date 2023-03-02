using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class NzdConfiguration : IEntityTypeConfiguration<NzdEntity>
	{
		public void Configure(EntityTypeBuilder<NzdEntity> builder)
		{
			builder
			.ToTable("NZD")
			.HasKey(currency => currency.Id);

			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(curency => curency.Nzd)
				.HasForeignKey<NzdEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
