using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.AudServices
{
	public class AudService : IAudService
	{
		private readonly IGenericRepository<AudEntity> _audRepository;

		public AudService(IGenericRepository<AudEntity> audRepository)
		{
			_audRepository = audRepository;
		}

		public void Create(AudEntity audEntity)
		{
			_audRepository.Create(audEntity);
		}

		public bool Delete(int id)
		{
			AudEntity dbRecord = _audRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if (dbRecord == null)
			{
				return false;
			}
			_audRepository.Remove(dbRecord);
			return true;
		}

		public List<AudEntity> GetAll()
		{
			List<AudEntity> dbRecord = _audRepository.Table
				.ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public AudEntity GetById(int id)
		{
			AudEntity dbRecord = _audRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(AudEntity audEntity)
		{
			try
			{
				_audRepository.Update(audEntity);
				_audRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
