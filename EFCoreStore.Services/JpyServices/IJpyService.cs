using EFCoreAPIData.Database.Entities;

namespace EFCoreStore.Services.JpyServices
{
	public interface IJpyService
	{
		void Create(JpyEntity jpyEntity);
		bool Delete(int id);
		bool Update(JpyEntity jpyEntity);
		JpyEntity GetById(int id);
		List<JpyEntity> GetAll();
	}
}
