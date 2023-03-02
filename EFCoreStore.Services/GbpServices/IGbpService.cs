using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.GbpServices
{
	public interface IGbpService
	{
		void Create(GbpEntity gbpEntity);
		bool Delete(int id);
		bool Update(GbpEntity gbpEntity);
		GbpEntity GetById(int id);
		List<GbpEntity> GetAll();
	}
}
