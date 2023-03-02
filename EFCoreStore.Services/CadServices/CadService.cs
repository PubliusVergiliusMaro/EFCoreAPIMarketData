using EFCoreAPIData.Database.Entities;
using EFCoreAPIData.Database.GenericRepository;

namespace EFCoreStore.Services.CadServices
{
	public class CadService : ICadService
	{
		private readonly IGenericRepository<CadEntity> _cadRepository;

		public CadService(IGenericRepository<CadEntity> cadRepository)
		{
			_cadRepository = cadRepository;
		}

		public void Create(CadEntity cadEntity)
		{
			_cadRepository.Create(cadEntity);
		}

		public bool Delete(int id)
		{
			CadEntity dbRecord = _cadRepository.Table
				.FirstOrDefault(curency => curency.Id == id);
			if (dbRecord == null)
			{
				return false;
			}
			_cadRepository.Remove(dbRecord);
			return true;
		}

		public List<CadEntity> GetAll()
		{
			List<CadEntity> dbRecord = _cadRepository.Table
				.ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public CadEntity GetById(int id)
		{
			CadEntity dbRecord = _cadRepository.Table
				.Where(curency => curency.Id == id)
				.FirstOrDefault();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}

		public bool Update(CadEntity cadEntity)
		{
			try
			{
				_cadRepository.Update(cadEntity);
				_cadRepository.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
