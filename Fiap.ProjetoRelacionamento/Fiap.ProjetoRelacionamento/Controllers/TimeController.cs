using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.ProjetoRelacionamento.Models;
using Fiap.ProjetoRelacionamento.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.ProjetoRelacionamento.Controllers
{
    public class TimeController : Controller
    {
        private Context _context;
        public TimeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Time t)
        {
            _context.Times.Add(t);
            _context.SaveChanges();
            TempData["msg"] = "O time " + t.Nome + " foi cadastrado";
            return RedirectToAction("Listar");
          
        }
        [HttpGet]
        public IActionResult Listar()
        {

            return View(_context.Times.ToList());
        }


    }
}