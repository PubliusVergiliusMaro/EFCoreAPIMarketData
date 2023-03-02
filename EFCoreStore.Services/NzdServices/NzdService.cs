using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.NzdServices
{
	public class NzdService : INzdService
	{
		private readonly IGenericRepository<NzdEntity> _nzdRepository;


		public NzdService(IGenericRepository<NzdEntity> nzdRepository)
		{
			_nzdRepository = nzdRepository;
		}

		public void Create(NzdEntity nzdEntity)
		{
			_nzdRepository.Create(nzdEntity);
		}

		public bool Delete(int id)
		{
			NzdEntity dbRecord = _nzdRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if (dbRecord == null)
			{
				return false;
			}
			_nzdRepository.Remove(dbRecord);
			return true;
		}

		public List<NzdEntity> GetAll()
		{
			List<NzdEntity> dbRecord = _nzdRepository.Table
			   .ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public NzdEntity GetById(int id)
		{
			NzdEntity dbRecord = _nzdRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(NzdEntity nzdEntity)
		{
			try
			{
				_nzdRepository.Update(nzdEntity);
				_nzdRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
