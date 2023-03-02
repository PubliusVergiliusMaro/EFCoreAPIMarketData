using EFCoreAPIData.Database.Configurations;
using EFCoreAPIData.Database.Entities;
using Microsoft.EntityFrameworkCore;
namespace EFCoreAPIData.Database
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<MarketsViewModelEntity> Market { get; set; }
		public DbSet<MarketEntity> Markets { get; set; }
		public DbSet<QuoteEntity> Quote { get; set; }
		public DbSet<AudEntity> Aud { get; set; }
		public DbSet<GbpEntity> Gbp { get; set; }
		public DbSet<CadEntity> Cad { get; set; }
		public DbSet<UsdEntity> Usd { get; set; }
		public DbSet<NzdEntity> Nzd { get; set; }
		public DbSet<JpyEntity> Jpy { get; set; }

		public ApplicationDbContext()
		{
			Database.Migrate();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=EFCoreAPIMarketDb;Trusted_Connection=True;TrustServerCertificate=True;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new MarketsViewModelConfiguration());
			modelBuilder.ApplyConfiguration(new MarketConfiguration());
			modelBuilder.ApplyConfiguration(new QuoteConfiguration());
			modelBuilder.ApplyConfiguration(new AudConfiguration());
			modelBuilder.ApplyConfiguration(new GbpConfiguration());
			modelBuilder.ApplyConfiguration(new CadConfiguration());
			modelBuilder.ApplyConfiguration(new UsdConfiguration());
			modelBuilder.ApplyConfiguration(new NzdConfiguration());
			modelBuilder.ApplyConfiguration(new JpyConfiguration());
		}
	}
}
