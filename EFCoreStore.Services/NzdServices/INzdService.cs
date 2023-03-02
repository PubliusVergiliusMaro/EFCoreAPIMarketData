using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.NzdServices
{
	public interface INzdService
	{
		void Create(NzdEntity nzdEntity);
		bool Delete(int id);
		bool Update(NzdEntity nzdEntity);
		NzdEntity GetById(int id);
		List<NzdEntity> GetAll();
	}
}
