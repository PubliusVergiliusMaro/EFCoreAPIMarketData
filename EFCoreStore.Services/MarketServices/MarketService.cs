using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace EFCoreStore.Services.MarketServices
{
	public class MarketService : IMarketService
	{
		private readonly IGenericRepository<MarketEntity> _marketRepository;

		public MarketService(IGenericRepository<MarketEntity> market)
		{
			_marketRepository = market;
		}

		public void Create(MarketEntity marketEntity)
		{
			_marketRepository.Create(marketEntity);
		}

		public bool Delete(int id)
		{
			MarketEntity dbRecord = _marketRepository.Table
				.FirstOrDefault(market => market.Id == id);
			if(dbRecord == null)
			{
				return false;
			}
			_marketRepository.Remove(dbRecord);
			return true;
		}

		public List<MarketEntity> GetAll()
		{
			List<MarketEntity> dbRecord = _marketRepository.Table
				.ToList();
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public MarketEntity GetById(int id)
		{
			MarketEntity dbRecord = _marketRepository.Table
				  .Include(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Gbp)
				   .Include(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Aud)
				  .Include(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Nzd)
				   .Include(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Cad)
				  .Include(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Jpy)
				   .Include(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Usd)
					 .FirstOrDefault(market => market.Id == id);
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(MarketEntity checkEntity)
		{
			try
			{
				_marketRepository.Update(checkEntity);
				_marketRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}
	}
}
