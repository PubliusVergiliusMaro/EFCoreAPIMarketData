using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.AudServices
{
	public interface IAudService 
	{
		void Create(AudEntity audEntity);
		bool Delete(int id);
		bool Update(AudEntity audEntity);
		AudEntity GetById(int id);
		List<AudEntity> GetAll();
	}

}
