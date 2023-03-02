using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.MarketServices
{
	public interface IMarketService
	{
		void Create(MarketEntity marketEntity);
		bool Delete(int id);
		bool Update(MarketEntity checkEntity);
		MarketEntity GetById(int id);
		List<MarketEntity> GetAll();
	}
}
