using GameShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class ShopController : Controller
    {

        private readonly IGameRepository gameRepo;

        public ShopController(IGameRepository gameRepo)
        {
            this.gameRepo = gameRepo;
        }

        [Route("Shop")]
        public async Task<IActionResult> Shop()
        {
            var games = await gameRepo.GetAllAsync();

            return View(games);
        }
    }
}
