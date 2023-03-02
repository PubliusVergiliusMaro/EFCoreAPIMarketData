using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAPIData.Database.Configurations
{
	public class CadConfiguration : IEntityTypeConfiguration<CadEntity>
	{
		public void Configure(EntityTypeBuilder<CadEntity> builder)
		{
			builder
			.ToTable("CAD")
			.HasKey(currency => currency.Id);

			builder
				.HasOne<QuoteEntity>(curency => curency.Quote)
				.WithOne(curency => curency.Cad)
				.HasForeignKey<CadEntity>(quote => quote.QuoteFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
