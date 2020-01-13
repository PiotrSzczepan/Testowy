using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testowy.Models;
using Testowy.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Testowy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamochodRepository _samochodRepository;
        
        public HomeController(ISamochodRepository samochodRepository)
        {
            _samochodRepository = samochodRepository;
        }

        public IActionResult Index()
        {
            var samochody = _samochodRepository.PobierzSamochody().OrderBy(s => s.Marka);

            HomeVM homeVM = new HomeVM()
            {
                Tytul = "Przeglad Samochodow",
                Samochody = samochody.ToList()
            };

            return View(homeVM);
        }
    }
}
