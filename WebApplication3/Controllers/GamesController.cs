using BusinessLogic.Entites;
using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_apple_store.Helpers;
using System.Data;
using System.Numerics;

namespace MVC_apple_store.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class GamesController : Controller
    {
        private readonly GameStoreDbContext context;

        public GamesController(GameStoreDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        public IActionResult Index(string searchStringName, string searchStringGanr)
        {
            var games = context.Games.Include(p => p.Ganr).ToList();

            if (!String.IsNullOrEmpty(searchStringName))
            {
                games = games.Where(g => g.Name.Contains(searchStringName)).ToList();
            }
            else if(!String.IsNullOrEmpty(searchStringGanr))
            {
                games = games.Where(g => g.Ganr.Name.Contains(searchStringGanr)).ToList();
            }

            return View(games);
        }

        public IActionResult Manage()
        {
            var phones = context.Games.Include(p => p.Ganr).ToList();

            return View(phones); 
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            if (id < 0) return BadRequest();

            var phone = context.Games.Find(id);

            if (phone == null) return NotFound();

            ViewBag.ReturnUrl = Request.Headers["Referer"].ToString();
            ViewBag.IsInCart = IsInCart(id);

            return View(phone);
        }

        private bool IsInCart(int id)
        {
            var productIds = HttpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null) return false;

            return productIds.Contains(id);
        }

        public IActionResult Create()
        {
            var colors = new SelectList(context.Ganrs, nameof(Ganr.Id), nameof(Ganr.Name));

            ViewBag.ColorList = colors;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Game phone)
        {
            if (!ModelState.IsValid)
            {
                var colors = new SelectList(context.Ganrs, nameof(Ganr.Id), nameof(Ganr.Name));
                ViewBag.ColorList = colors;
                return View(phone);
            }

            context.Games.Add(phone);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "Game was created successfully!";

            return RedirectToAction(nameof(Manage));
        }

        public IActionResult Edit(int id)
        {
            if (id < 0) return BadRequest();

            var phone = context.Games.Find(id);

            if (phone == null) return NotFound();

            var colors = new SelectList(context.Ganrs, nameof(Ganr.Id), nameof(Ganr.Name));
            ViewBag.ColorList = colors;

            return View(phone);
        }

        [HttpPost]
        public IActionResult Edit(Game phone)
        {
            if (!ModelState.IsValid)
            {
                var colors = new SelectList(context.Ganrs, nameof(Ganr.Id), nameof(Ganr.Name));
                ViewBag.ColorList = colors;
                return View(phone);
            }

            context.Games.Update(phone);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "Game was edited successfully!";

            return RedirectToAction(nameof(Manage));
        }

        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var phone = context.Games.Find(id);

            if (phone == null) return NotFound();

            context.Games.Remove(phone);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "Game was deleted successfully!";

            return RedirectToAction(nameof(Manage));
        }
    }
}
