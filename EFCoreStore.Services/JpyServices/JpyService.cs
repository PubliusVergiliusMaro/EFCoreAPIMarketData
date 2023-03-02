using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.JpyServices
{
	public class JpyService : IJpyService
	{
		private readonly IGenericRepository<JpyEntity> _jpyRepository;

		public JpyService(IGenericRepository<JpyEntity> jpyRepository)
		{
			_jpyRepository = jpyRepository;
		}

		public void Create(JpyEntity jpyEntity)
		{
			_jpyRepository.Create(jpyEntity);
		}

		public bool Delete(int id)
		{
			JpyEntity dbRecord = _jpyRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if (dbRecord == null)
			{
				return false;
			}
			_jpyRepository.Remove(dbRecord);
			return true;
		}

		public List<JpyEntity> GetAll()
		{
			List<JpyEntity> dbRecord = _jpyRepository.Table
				.ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public JpyEntity GetById(int id)
		{
			JpyEntity dbRecord = _jpyRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(JpyEntity jpyEntity)
		{
			try
			{
				_jpyRepository.Update(jpyEntity);
				_jpyRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
