using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class JpyConfiguration : IEntityTypeConfiguration<JpyEntity>
	{
		public void Configure(EntityTypeBuilder<JpyEntity> builder)
		{
			builder
			.ToTable("JPY")
			.HasKey(currency => currency.Id);

			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(curency => curency.Jpy)
				.HasForeignKey<JpyEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
