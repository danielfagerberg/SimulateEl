using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iniatiative_train.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimulateEl.Models;

namespace SimulateEl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRealConsumptionRepository _realConsumptionRepository;

        public HomeController(ILogger<HomeController> logger, IRealConsumptionRepository realConsumptionRepository)
        {
            _logger = logger;
            _realConsumptionRepository = realConsumptionRepository;
        }
        

        // GET: TrackLocationController
        public ActionResult Index()
        {
            var model = _realConsumptionRepository.GetAllRealConsumptions();
            return View(model);
        }


        public IActionResult Dashboard()
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
