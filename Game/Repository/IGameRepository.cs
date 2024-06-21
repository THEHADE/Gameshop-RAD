using GameShop.Models.Entities;

namespace GameShop.Repository
{
    public interface IGameRepository
    {
        Task<List<Game>> GetAllAsync();
        Task<Game> GetByNameAsync(string name);
        Task<List<Game>> GetAllByCategoryAsync(string category);
    }
}
