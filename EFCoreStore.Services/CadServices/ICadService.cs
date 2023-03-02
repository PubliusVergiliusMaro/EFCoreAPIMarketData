using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.CadServices
{
	public interface ICadService
	{
		void Create(CadEntity audEntity);
		bool Delete(int id);
		bool Update(CadEntity audEntity);
		CadEntity GetById(int id);
		List<CadEntity> GetAll();
	}
}
