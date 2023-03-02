using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class MarketConfiguration : IEntityTypeConfiguration<MarketEntity>
	{
		public void Configure(EntityTypeBuilder<MarketEntity> builder)
		{
			builder
				.ToTable("Markets")
				.HasKey(markets => markets.Id);
			builder
				.HasOne<MarketsViewModelEntity>(markets=>markets.MarketViewModelEntity)
				.WithMany(marketModel=>marketModel.Markets)
				.HasForeignKey(markets=>markets.MarketViewModelFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
