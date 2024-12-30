using Microsoft.AspNetCore.Mvc;
using ThreeAmigos.Domain.Entities;
using ThreeAmigos.Domain.Interfaces.Services;
using ThreeAmigos.UI.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ThreeAmigos.UI.Controllers
{
    public class BrandsController : Controller
    {
        
        private readonly IBrandService _service;

        public BrandsController(IBrandService service)
        {
            
            _service = service;

            //TODO simple seed
            _service.AddBrandAsync(new Brand
            {
                Id = 1,
                Name = "Soggy Sponge",
                Active = true
            });

            _service.AddBrandAsync(new Brand
            {
                Id = 2,
                Name = "Damp Squib",
                Active = false
            });

            _service.AddBrandAsync(new Brand
            {
                Id = 3,
                Name = "Chinese spoons",
                Active = true
            });


        }
        
        public async Task<IActionResult> Index()
        {
            
            return View(await _service.GetBrandsAsync());
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
