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
    }
}
