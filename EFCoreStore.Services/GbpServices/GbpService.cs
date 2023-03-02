using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.GbpServices
{
	public class GbpService : IGbpService
	{
		private readonly IGenericRepository<GbpEntity> _gbpRepository;

		public GbpService(IGenericRepository<GbpEntity> gbpRepository)
		{
			_gbpRepository = gbpRepository;
		}

		public void Create(GbpEntity gbpEntity)
		{
			_gbpRepository.Create(gbpEntity);
		}

		public bool Delete(int id)
		{
			GbpEntity dbRecord = _gbpRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if (dbRecord == null)
			{
				return false;
			}
			_gbpRepository.Remove(dbRecord);
			return true;
		}

		public List<GbpEntity> GetAll()
		{
			List<GbpEntity> dbRecord = _gbpRepository.Table
				.ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public GbpEntity GetById(int id)
		{
			GbpEntity dbRecord = _gbpRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(GbpEntity gbpEntity)
		{
			try
			{
				_gbpRepository.Update(gbpEntity);
				_gbpRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
