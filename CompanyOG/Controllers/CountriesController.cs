using CompanyOG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyOG.Controllers
{
    //Countries/Index
    public class CountriesController : Controller
    {
        private readonly CompanyContext _db;
        public CountriesController(CompanyContext db) {
            _db=db;
        }
        public async Task<IActionResult> Index()
        {
            var countries = await _db.CountryRegions.ToListAsync();
            return View(countries);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CountryRegion newCountry)
        {
            if(ModelState.IsValid) { 
            _db.CountryRegions.Add(newCountry); //tylk ow ramie w repo
            await _db.SaveChangesAsync(); // tu faktycznie dodaje
        }
            // RedirectToAction("Index") zamiast View("Index") bo musielibysmy przekaza liste a tak to wywoluje ta funkcje
            return RedirectToAction("Index");
        }
    }
}
