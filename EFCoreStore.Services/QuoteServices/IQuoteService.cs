using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.QuoteServices
{
	public interface IQuoteService
	{
		void Create(QuoteEntity productEntity);
		bool Update(QuoteEntity productEntity);
		bool Delete(int id);
		QuoteEntity GetById(int id);
		List<QuoteEntity> GetAll();
		
	}
}
