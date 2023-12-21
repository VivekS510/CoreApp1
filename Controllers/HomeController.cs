using CoreApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoreApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserAppContext _dbcontext;

        public HomeController(ILogger<HomeController> logger, UserAppContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
           
        }

        public IActionResult Index()
        {
            var data = _dbcontext.UserRegisters.ToList();
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
