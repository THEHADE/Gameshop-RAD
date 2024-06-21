using GameShop.Models;
using GameShop.Models.Dal;
using GameShop.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameRepository gameRepo;

        public HomeController(IGameRepository gameRepo)
        {
            this.gameRepo = gameRepo;
        }

        public async Task<IActionResult> Index()
        {
            var games = await gameRepo.GetAllAsync();

            return View(games);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        
    }
}
