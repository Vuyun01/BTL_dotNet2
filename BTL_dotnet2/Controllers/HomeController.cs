using BTL_dotnet2.Data;
using BTL_dotnet2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BTL_dotnet2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductType> types = await _context.ProductType.ToListAsync();
            ViewData["Types"] = types;
            var products = _context.Products.Include(p => p.Category).Include(t => t.ProductType);
            return View(await products.ToListAsync());
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
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