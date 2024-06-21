using GameShop.Models.Dal;
using GameShop.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Repository
{
    public class GameRepo : IGameRepository
    {
        private readonly GameShopDbContext ctx;

        public GameRepo(GameShopDbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<List<Game>> GetAllAsync()
        {
            var games = await ctx.Games.ToListAsync();

            return games;
        }

        public async Task<Game> GetByNameAsync(string name)
        {
            var game = await ctx.Games.Where(c=>c.Name.StartsWith(name)).FirstOrDefaultAsync();

            return game;
        }

        public async Task<List<Game>> GetAllByCategoryAsync(string category)
        {
            var games = await ctx.Games.Where(c=>c.Category.StartsWith(category)).ToListAsync();

            return games;
        }
    }
}
