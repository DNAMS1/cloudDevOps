using Microsoft.AspNetCore.Mvc;
using ThreeAmigos.Domain.Entities;
using ThreeAmigos.Domain.Interfaces.Services;
using ThreeAmigos.UI.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ThreeAmigos.UI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
        {

            _service = service;

            //TODO simple seed
            _service.AddCategoryAsync(new Category
            {
                Id = 1,
                Name = "Covers",
                Description = "Davison Stores pride ourselves on our poor range of covers for your mobile device at premium prices.  If you're lukcy your phone or tablet will be protected from any dents, scratches and scuffs.",
                Active = true
            });

            _service.AddCategoryAsync(new Category
            {
                Id = 2,
                Name = "Case",
                Description = "Browse our wide range of cases for phones and tablets that will help you to keep your mobile device protected from the elements.",
                Active = false
            });

        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _service.GetCategorysAsync());
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
