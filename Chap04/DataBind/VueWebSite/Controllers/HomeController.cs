using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using VueWebSite.Models;

namespace VueWebSite.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext _context;
        public HomeController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerCountry()
        {
            ViewBag.Country = new SelectList(
                _context.Customers.Select(c => c.Country).OrderBy(country => country).Distinct());
            return View();
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
