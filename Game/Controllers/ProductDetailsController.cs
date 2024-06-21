using GameShop.Models.ViewModels;
using GameShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GameShop.Controllers
{
    public class ProductDetailsController : Controller
    {
        private readonly IGameRepository gameRepo;

        public ProductDetailsController(IGameRepository gameRepo)
        {
            this.gameRepo = gameRepo;
        }

        [Route("ProductDetails")]
        public async Task<IActionResult> Index([FromQuery]string name)
        {
            var product = await gameRepo.GetByNameAsync(name);
            var games = await gameRepo.GetAllAsync();
            ViewData["Title"] = $"Game Shop : {product.Name}";

            var model = new ProductVM()
            {
                Games = games,
                Product = product
            };

            return View(model);
        }
    }
}
