using Newtonsoft.Json;
namespace EFCoreAPIData.Database.Entities
{
	public class QuoteEntity
	{
		public int Id { get; set; }
			[JsonProperty("AUD")]
			public AudEntity Aud { get; set; }
			[JsonProperty("GBP")]
			public GbpEntity Gbp { get; set; }
			[JsonProperty("CAD")]
			public CadEntity Cad { get; set; }
			[JsonProperty("USD")]
			public UsdEntity Usd { get; set; }
			[JsonProperty("NZD")]
			public NzdEntity Nzd { get; set; }
			[JsonProperty("JPY")]
			public JpyEntity Jpy { get; set; }

		public int? MarketFK { get; set; }
		public MarketEntity MarketEntity { get; set; }
	}
}
