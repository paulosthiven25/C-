using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.Asp.net.Models;
using _04_Fiap.Web.Asp.net.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.Asp.net.Controllers
{
    public class VeiculoController : Controller
    {
        private LocadoraContext _context;

        public VeiculoController(LocadoraContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Veiculos.ToList());
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Veiculo v)
        {
            _context.Veiculos.Add(v);
            _context.SaveChanges();
            TempData["msg"] = "O veiculo " + v.Modelo + " foi cadastrado";
            return RedirectToAction("Listar");
        }
    }
}