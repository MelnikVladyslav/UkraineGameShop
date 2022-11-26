using DataAccess;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MVC_apple_store.Helpers;
using MVC_apple_store.Services;
using System.Numerics;

namespace MVC_apple_store.Controllers
{
    public class CartController : Controller
    {
        private readonly GameStoreDbContext context;
        private readonly ICartService cartService;

        public CartController(ICartService cartService, GameStoreDbContext context)
        {
            this.context = context;
            this.cartService = cartService;
        }
        public IActionResult Index()
        {
            var products = cartService.GetProductsFromCart();

            return View(products);
        }

        public IActionResult Add(int productId)
        {
            if (productId < 0) return BadRequest();

            var phone = context.Games.Find(productId);

            if (phone == null) return NotFound();

            cartService.AddProductToCart(productId);

            return RedirectToAction("Details", "Games", new { id = productId });
        }
        public IActionResult Remove(int productId)
        {
            if (productId < 0) return BadRequest();

            var phone = context.Games.Find(productId);

            if (phone == null) return NotFound();

            cartService.RemoveProductFromCart(productId);

            return RedirectToAction("Details", "Games", new { id = productId });
        }

    }
}