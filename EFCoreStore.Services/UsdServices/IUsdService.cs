using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.UsdServices
{
	public interface IUsdService
	{
		void Create(UsdEntity usdEntity);
		bool Delete(int id);
		bool Update(UsdEntity usdEntity);
		UsdEntity GetById(int id);
		List<UsdEntity> GetAll();
	}
}
