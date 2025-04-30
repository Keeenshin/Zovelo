using Microsoft.AspNetCore.Mvc;
using Testing1.Data;
using Testing1.Models;
using System.Linq;
using System.Collections.Generic;

namespace Testing1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var featuredProducts = _context.Products
                                   .Where(p => p.BestSelling) 
                                   .Take(4) 
                                   .ToList();

            ViewBag.FeaturedProducts = featuredProducts; 
            return View();
        }


        public IActionResult Catalogue()
        {

            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            ViewData["ProductImages"] = product.ImageUrls.Split(',').ToList();
            ViewData["Recommendations"] = GetRecommendations(product.Type, product.Name);

            return View(product);
        }
    

        private List<Product> GetRecommendations(string type, string excludeName)
        {
            return _context.Products
                .Where(p => p.Type == type && p.Name != excludeName)
                .OrderByDescending(p => p.DateAdded)
                .Take(3)
                .ToList();
        }
    }
}
