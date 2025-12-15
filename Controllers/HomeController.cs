using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HolaMundo.Models;
using HolaMundo.Services;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        public IPaisRepositorioEnMemoria Repositorio { get; }

        public HomeController(IPaisRepositorioEnMemoria repositorio)
        {
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            List<string> paises = Repositorio.Obtenertodos();
            return View(paises);
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
    }
}
