using Microsoft.AspNetCore.Mvc;
using Testing1.Data;
using Zovelo.Services;
using Testing1.Models;
using Zovelo.Models;

namespace Testing1.Controllers
{
    public class CartController : Controller
    {
        private readonly ShoppingCartService _shoppingCartService;
        private readonly ApplicationDbContext _context;

        public CartController(ShoppingCartService shoppingCartService, ApplicationDbContext context)
        {
            _shoppingCartService = shoppingCartService;
            _context = context;
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                return NotFound();
            }

            _shoppingCartService.AddToCart(product, quantity);

            var productImagePath = Url.Content("~/images/" + product.ImageUrls.Split(',')[0]);

            return Json(new
            {
                success = true,
                productName = product.Name,
                productPrice = product.Price,
                productImage = productImagePath
            });
        }

        public IActionResult Index()
        {
            var cartItems = _shoppingCartService.GetCartItems();
            return View(cartItems);  
        }

        public IActionResult RemoveFromCart(int productId)
        {
            _shoppingCartService.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }

        public IActionResult ClearCart()
        {
            _shoppingCartService.ClearAllItems();
            return RedirectToAction("Index");
        }
    }
}
