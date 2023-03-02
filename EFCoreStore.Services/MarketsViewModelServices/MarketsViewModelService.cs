using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EFCoreStore.Services.MarketsViewModelServices
{
	public class MarketsViewModelService : IMarketsViewModelService
	{
		private readonly IGenericRepository<MarketsViewModelEntity> _modelViewRepository;
		
		public MarketsViewModelService(IGenericRepository<MarketsViewModelEntity> modelViewRepository)
		{
			_modelViewRepository = modelViewRepository;
		}

		public void Create(MarketsViewModelEntity market)
		{
			_modelViewRepository.Create(market);
		}

		public bool Delete(int id)
		{
			MarketsViewModelEntity dbRecord = _modelViewRepository.Table
			   .FirstOrDefault(market => market.Id == id);

			if (dbRecord == null)
			{
				return false;
			}
			_modelViewRepository.Remove(dbRecord);
			return Update(dbRecord);
		}

		public MarketsViewModelEntity GetById(int id)
		{
			MarketsViewModelEntity dbRecord = _modelViewRepository.Table
				.Include(market => market.Markets)
				  .ThenInclude(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Gbp)
				.Include(market => market.Markets)
				   .ThenInclude(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Aud)
				 .Include(market => market.Markets)
				  .ThenInclude(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Nzd)
				.Include(market => market.Markets)
				   .ThenInclude(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Cad)
				 .Include(market => market.Markets)
				  .ThenInclude(markets => markets.Quotes)
					.ThenInclude(quotes => quotes.Jpy)
				.Include(market => market.Markets)
				   .ThenInclude(markets => markets.Quotes)
					 .ThenInclude(quotes => quotes.Usd)
					 .FirstOrDefault(modelViw => modelViw.Id == id);
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public async Task<MarketsViewModelEntity> GetMarketsFromApiAsync(string ALL_MARKETS_URL)
		{
			var client = new HttpClient();
			var message = await client.GetAsync(ALL_MARKETS_URL);
			message.EnsureSuccessStatusCode();
			var context = await message.Content.ReadAsStringAsync();

			try
			{
				var markets = JsonConvert.DeserializeObject<MarketsViewModelEntity>(context);
				return markets;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}
		public bool Update(MarketsViewModelEntity marketModelViewEntity)
		{
			try
			{
				_modelViewRepository.Table.Update(marketModelViewEntity);
				_modelViewRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
