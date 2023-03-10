using Newtonsoft.Json;

namespace EFCoreAPIData.Database.Entities
{
	public class MarketEntity
	{
		public int Id { get; set; }
		[JsonProperty("exchange_id")]
		public string ExchangeId { get; set; }
		[JsonProperty("symbol")]
		public string Symbol { get; set; }
		[JsonProperty("base_asset")]
		public string BaseAsset { get; set; }
		[JsonProperty("quote_asset")]
		public string QuoteAsset { get; set; }
		[JsonProperty("price_unconverted")]
		public double PriceUnconverted { get; set; }
		[JsonProperty("price")]
		public double Price { get; set; }
		[JsonProperty("change_24h")]
		public double Change24H { get; set; }
		[JsonProperty("spread")]
		public double Spread { get; set; }
		[JsonProperty("volume_24h")]
		public double Volume24H { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }
		[JsonProperty("quote")]
		public QuoteEntity Quotes { get; set; }

		public int? MarketViewModelFK { get; set; }
		public MarketsViewModelEntity MarketViewModelEntity { get; set; }
	}
}
