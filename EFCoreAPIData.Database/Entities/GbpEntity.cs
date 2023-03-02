using Newtonsoft.Json;

namespace EFCoreAPIData.Database.Entities
{
	public class GbpEntity
	{
		public int Id { get; set; }
		[JsonProperty("price")]
		public double Price { get; set; }
		[JsonProperty("volume_24h")]
		public double Volume24H { get; set; }

		public int? QuoteFK { get; set; }
		public QuoteEntity Quote { get; set; }
	}
}
