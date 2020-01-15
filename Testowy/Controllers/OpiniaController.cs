using Microsoft.AspNetCore.Mvc;
using Testowy.Models;

namespace Testowy.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            this.opiniaRepository = opiniaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Opinia opinia)
        {
            if (ModelState.IsValid)
            {
                opiniaRepository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }
            return View(opinia);
        }

        public IActionResult OpiniaWyslana()
        {
            return View();
        }
    }
}