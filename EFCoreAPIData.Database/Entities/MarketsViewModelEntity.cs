using Newtonsoft.Json;

namespace EFCoreAPIData.Database.Entities
{
	public class MarketsViewModelEntity 
	{
		public MarketsViewModelEntity()
		{
			Markets = new List<MarketEntity>();
		}
		public int Id { get; set; }
		[JsonProperty("markets")]
		public List<MarketEntity> Markets { get; set; }
	}
}
