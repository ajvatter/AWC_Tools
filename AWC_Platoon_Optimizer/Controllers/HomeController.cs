using System.Diagnostics;
using AWC_Platoon_Optimizer.DAL;
using Microsoft.AspNetCore.Mvc;
using AWC_Platoon_Optimizer.Models;
using AWC_Platoon_Optimizer.Services;

namespace AWC_Platoon_Optimizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly AwcContext _dbContext;
        private readonly ApiService _apiService = new ApiService();

        public IActionResult Index()
        {
            var token = _apiService.GetToken().Result;
            var response = _apiService.GetApiCategories(token.Content).Result;

            ViewBag.Content = response;

            return View();                   
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
