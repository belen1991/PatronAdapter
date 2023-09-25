using TemperaturaGrupo6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using Microsoft.Extensions.Options;
using TemperaturaGrupo6.Interfaces;
using TemperaturaGrupo6.Adapter;

namespace TemperaturaGrupo6.Controllers
{
    public class HomeController : Controller
    {
        private static List<DispositivoTemperatura> dispositivos = new List<DispositivoTemperatura>();
        private ITemperatura temperatura;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(dispositivos);
        }

        public IActionResult Dispositivo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dispositivo(DispositivoTemperatura dispositivoTemperatura)
        {
            if (ModelState.IsValid)
            {
                if (dispositivoTemperatura.tipo == Enums.DispositivosTemperaturaEnum.Celcious)
                {
                    temperatura = new DispositivoCelsius(dispositivoTemperatura.Temperatura);
                }
                else { 
                    DispositivoFahrenheit dispositivoFahrenheit = new DispositivoFahrenheit(dispositivoTemperatura.Temperatura);
                    temperatura = new AdaptadorFahrenheitACelsius(dispositivoFahrenheit);
                }
                dispositivoTemperatura.TemperaturaCelsius = temperatura.ObtenerTemperaturaEnCelsius();
                dispositivos.Add(dispositivoTemperatura);
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}