using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class QuoteConfiguration : IEntityTypeConfiguration<QuoteEntity>
	{
		public void Configure(EntityTypeBuilder<QuoteEntity> builder)
		{
			builder 
				.ToTable("Quote")
				.HasKey(quote=>quote.Id);
			builder
				.HasOne<MarketEntity>(quote => quote.MarketEntity)
				.WithOne(market=>market.Quotes)
				.HasForeignKey<QuoteEntity>(quote=>quote.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
