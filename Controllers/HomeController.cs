using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cosmetic_store.Models;
using cosmetic_store.Services;

namespace cosmetic_store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Products()
        {
            var service = new MakeUpService();
            var products = await service.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.Brand);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Rating);
                Console.WriteLine(product.Product_Colors);
            }

            return View(products);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
