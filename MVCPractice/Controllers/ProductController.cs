using Microsoft.AspNetCore.Mvc;
using MVCPractice.Models;
using System.Collections.Generic;

namespace MVCPractice.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="pen",Price=10.00},
                new Product { Id = 2,Name="pencil",Price=20.21},
                new Product { Id = 3,Name="Glue",Price=30.22},
                new Product { Id = 4,Name="box",Price=40.31},
                new Product { Id = 5,Name="color",Price=50.11}

            };
            ViewData["list"]=products;
                
            return View();
        }
    }
}
