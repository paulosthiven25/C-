using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using formularioSimples.Models;
using Microsoft.AspNetCore.Mvc;

namespace formularioSimples.Controllers
{
    public class ViagemController : Controller
    {
        private static IList<Viagem> _lista = new List<Viagem>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }


        [HttpPost]
        public IActionResult Cadastrar(Viagem v )
        {
            _lista.Add(v);
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }
    }
}