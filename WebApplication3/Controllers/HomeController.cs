using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.Models;

namespace MVC_apple_store.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameStoreDbContext context;

        public HomeController(GameStoreDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var games = context.Games.Include(p => p.Ganr).ToList();
            return View(games);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}