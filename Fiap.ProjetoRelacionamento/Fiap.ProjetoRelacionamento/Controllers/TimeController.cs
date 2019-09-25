using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.ProjetoRelacionamento.Models;
using Fiap.ProjetoRelacionamento.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Cadastrar(Time t,Treinador treinador)
        {
            
            
            
            _context.Times.Add(t);
            _context.SaveChanges();


            TempData["msg"] = "O time " + t.Nome + " foi cadastrado";
            return RedirectToAction("Listar");
          
        }
        [HttpGet]
        public IActionResult Listar()
        {

            return View(_context.Times.Include(c => c.Tecnico).ToList());
        }

        [HttpGet]
        public IActionResult Pesquisar(Esporte? esporte)
        {
            var lista = _context.Times.Where(e => e.Esporte == esporte || esporte == null).Include(c => c.Tecnico).ToList();
            return View("Listar", lista);
        }

        [HttpGet]
        public IActionResult VerDetalhes(int id)
        {
            var time = _context.Times.Include(c => c.Tecnico).Include(c => c.Jogadores).Where(c => c.Codigo == id).FirstOrDefault();
            return View(time);
            
        }


    }
}