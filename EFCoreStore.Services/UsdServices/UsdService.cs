using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.UsdServices
{
	public class UsdService : IUsdService
	{
		public readonly IGenericRepository<UsdEntity> _usdRepository;

		public UsdService(IGenericRepository<UsdEntity> usdRepository)
		{
			_usdRepository = usdRepository;
		}

		public void Create(UsdEntity usdEntity)
		{
			_usdRepository.Create(usdEntity);
		}

		public bool Delete(int id)
		{
			UsdEntity dbRecord = _usdRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if(dbRecord == null)
			{
				return false;
			}
			_usdRepository.Remove(dbRecord);
			return true;
		}

		public List<UsdEntity> GetAll()
		{
			List<UsdEntity> dbRecord = _usdRepository.Table
				.ToList();
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public UsdEntity GetById(int id)
		{
			UsdEntity dbRecord = _usdRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if(dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(UsdEntity usdEntity)
		{
			try
			{
				_usdRepository.Update(usdEntity);
				_usdRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
