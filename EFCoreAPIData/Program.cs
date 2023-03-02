using EFCoreAPIData.Database;
using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;
using EFCoreStore.Services.AudServices;
using EFCoreStore.Services.CadServices;
using EFCoreStore.Services.GbpServices;
using EFCoreStore.Services.JpyServices;
using EFCoreStore.Services.MarketServices;
using EFCoreStore.Services.MarketsViewModelServices;
using EFCoreStore.Services.NzdServices;
using EFCoreStore.Services.QuoteServices;
using EFCoreStore.Services.UsdServices;

namespace EFCoreAPIData
{
	public class Program
	{
		private const string ALL_MARKETS_URL = "https://cryptingup.com/api/markets";

		private static HttpClient client;
		static ApplicationDbContext dbContext;
		static IGenericRepository<MarketsViewModelEntity> marketsModelRepository;
		static IGenericRepository<MarketEntity> marketRepository;
		static IGenericRepository<QuoteEntity> quoteRepository;
		static IGenericRepository<AudEntity> audRepository;
		static IGenericRepository<CadEntity> cadRepository;
		static IGenericRepository<GbpEntity> gbpRepository;
		static IGenericRepository<JpyEntity> jpyRepository;
		static IGenericRepository<NzdEntity> nzdRepository;
		static IGenericRepository<UsdEntity> usdRepository;

		static IMarketsViewModelService marketModelService;
		static IMarketService marketService;
		static IQuoteService quoteService;
		static IAudService audService;
		static ICadService cadService;
		static IGbpService gbpService;
		static IJpyService jpyService;
		static INzdService nzdService;
		static IUsdService usdService;


		static void Main(string[] args)
		{
			dbContext = new ApplicationDbContext();
			marketsModelRepository = new GenericRepository<MarketsViewModelEntity>(dbContext);
			marketRepository = new GenericRepository<MarketEntity>(dbContext);
			quoteRepository = new GenericRepository<QuoteEntity>(dbContext);
			audRepository = new GenericRepository<AudEntity>(dbContext);
			cadRepository = new GenericRepository<CadEntity>(dbContext);
			gbpRepository = new GenericRepository<GbpEntity>(dbContext);
			jpyRepository = new GenericRepository<JpyEntity>(dbContext);
			nzdRepository = new GenericRepository<NzdEntity>(dbContext);
			usdRepository = new GenericRepository<UsdEntity>(dbContext);

			marketModelService = new MarketsViewModelService(marketsModelRepository);
			marketService = new MarketService(marketRepository);
			quoteService = new QuoteService(quoteRepository);
			audService = new AudService(audRepository);
			cadService = new CadService(cadRepository);
			gbpService = new GbpService(gbpRepository);
			jpyService = new JpyService(jpyRepository);
			nzdService = new NzdService(nzdRepository);
			usdService = new UsdService(usdRepository);

			//SynchronizeMarketsFromApiToDb();
			Console.WriteLine("Successfully");
			Console.ReadLine();
		}
		static async void SynchronizeMarketsFromApiToDb()
		{
			MarketsViewModelEntity market = await marketModelService.GetMarketsFromApiAsync(ALL_MARKETS_URL);
			marketModelService.Create(market);
		}
	}
}