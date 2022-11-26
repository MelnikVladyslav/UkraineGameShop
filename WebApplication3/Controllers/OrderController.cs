using DataAccess;
using Microsoft.AspNetCore.Mvc;
using MVC_apple_store.Services;
using Microsoft.AspNetCore.Identity;
using BusinessLogic.Entites;

namespace MVC_apple_store.Controllers
{
    public class OrdersController : Controller
    {
        private readonly GameStoreDbContext context;
        private readonly ICartService cartService;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public OrdersController(GameStoreDbContext context,
                                ICartService cartService,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager)
        {
            this.context = context;
            this.cartService = cartService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) return BadRequest();

            var user = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);


            var orders = context.Orders.Where(o => o.ClientId == user.Id).ToList();

            return View(orders);
        }

        public async Task<IActionResult> Add()
        {
            var products = cartService.GetProductsFromCart().ToList();

            if (HttpContext.User.Identity == null) return BadRequest();

            var user = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            Order newOrder = new Order()
            {
                Date = DateTime.UtcNow,
                Products = (IEnumerable<Game>)products,
                TotalPrice = products.Sum(p => p.Price),
                ClientId = user.Id
            };

            context.Orders.Add(newOrder);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}