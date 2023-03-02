using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.MarketsViewModelServices
{
	public interface IMarketsViewModelService
	{
		void Create(MarketsViewModelEntity marketViewModelEntity);
		bool Delete(int id);
		bool Update(MarketsViewModelEntity marketViewModelEntity);
		MarketsViewModelEntity GetById(int id);
		Task<MarketsViewModelEntity> GetMarketsFromApiAsync(string ALL_MARKETS_URL);
	}
}
