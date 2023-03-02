using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class MarketsViewModelConfiguration : IEntityTypeConfiguration<MarketsViewModelEntity>
	{
		public void Configure(EntityTypeBuilder<MarketsViewModelEntity> builder)
		{
			builder.ToTable("Market").HasKey(market=>market.Id);
		}
	}
}
