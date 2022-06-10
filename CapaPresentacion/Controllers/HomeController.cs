﻿using CapaNegocio;
using CapaPresentacion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listado = Prestamo.Listar();
            return View(listado);
        }

        public IActionResult Registrar()
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