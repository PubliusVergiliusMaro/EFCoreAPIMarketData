using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace EFCoreStore.Services.QuoteServices
{
	public class QuoteService : IQuoteService
	{
		private readonly IGenericRepository<QuoteEntity> _quoteRepository;

		public QuoteService(IGenericRepository<QuoteEntity> quoteRepository)
		{
			_quoteRepository = quoteRepository;

		}
		public void Create(QuoteEntity quote)
		{
			_quoteRepository.Create(quote);
		}

		public bool Delete(int Id)
		{
			QuoteEntity dbRecord = _quoteRepository.Table
				.FirstOrDefault(q => q.Id == Id);
			if (dbRecord == null)
			{
				return false;
			}
			_quoteRepository.Remove(dbRecord);
			return true;
		}
		
		public QuoteEntity GetById(int id)
		{
			QuoteEntity dbRecord = _quoteRepository.Table
				.Include(q => q.Aud)
				.Include(q => q.Gbp)
				.Include(q => q.Usd)
				.Include(q => q.Nzd)
				.Include(q => q.Jpy)
				.Include(q => q.Cad)
				.FirstOrDefault(q => q.Id == id);
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public List<QuoteEntity> GetAll()
		{
			List<QuoteEntity> dbRecord = _quoteRepository.Table
				.ToList();
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(QuoteEntity productEntity)
		{
			try
			{
				_quoteRepository.Update(productEntity);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	   
	}
}
