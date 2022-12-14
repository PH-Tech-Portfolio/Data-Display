using CovidDataDisplay.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CovidDataDisplay.Controllers
{
    public class HomeController : Controller
    {
        private readonly CovidCasesAlbertaDbContext _context;

        public HomeController(CovidCasesAlbertaDbContext contex)
        {
            _context = contex;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetSomeData()
        //{
        //    return Ok(await _context.Covid19AlbertaStatisticsData.ToListAsync());

        //}

        public IActionResult Index()
        {
            IEnumerable<Covid19AlbertaStatisticsDatum> objList = _context.Covid19AlbertaStatisticsData;
            return View(objList);
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




        // Methods (probably not right way to do it but a simple temp fix for quick functionality
        //public int NextItems(ref int count) => count += 100;
        //public int PrevItems(ref int count) => count -= 100;
        //[HttpPost]
        //public IActionResult SomeMethod(int count)
        //{
        //    return View();
        //}

    }
}