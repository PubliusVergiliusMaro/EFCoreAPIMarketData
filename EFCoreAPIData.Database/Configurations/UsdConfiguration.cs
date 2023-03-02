using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class UsdConfiguration : IEntityTypeConfiguration<UsdEntity>
	{
		public void Configure(EntityTypeBuilder<UsdEntity> builder)
		{
			builder
			.ToTable("USD")
			.HasKey(currency => currency.Id);

			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(curency => curency.Usd)
				.HasForeignKey<UsdEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
