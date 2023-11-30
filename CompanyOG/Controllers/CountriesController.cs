using CompanyOG.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyOG.Controllers
{
    //Countries/Index
    public class CountriesController : Controller
    {
        private readonly CompanyContext _db;
        public CountriesController(CompanyContext db) {
            _db=db;
        }
        public IActionResult Index()
        {
            var countries = _db.CountryRegions.ToList();
            return View(countries);
        }
    }
}
