using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using formularioSimples.Models;
using Microsoft.AspNetCore.Mvc;

namespace formularioSimples.Controllers
{
    public class UsuarioController : Controller
    {
        private static IList<Usuario> _lista = new List<Usuario>();

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
        public IActionResult Cadastrar(Usuario u)
        {
            _lista.Add(u);
            
            TempData["msg"] = "O usuario " + u.Nome + " foi cadastrado";
            return View(u);
        }
    }
}