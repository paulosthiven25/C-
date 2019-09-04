using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.Asp.net.Models;
using _04_Fiap.Web.Asp.net.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.Asp.net.Controllers
{
    public class ProprietarioController : Controller
    {
        private LocadoraContext _context;

        public ProprietarioController(LocadoraContext context)
        {
            _context = context;
        }
        [HttpGet]
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
        public IActionResult Cadastrar(Proprietario p)
        {
            _context.Proprietarios.Add(p);
            _context.SaveChanges();
            TempData["msg"] = "O propeirtario " + p.Nome + " foi cadastrado";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Proprietarios.ToList());


        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var prop = _context.Proprietarios.Find(id);
            _context.Remove(prop);
            _context.SaveChanges();
            return RedirectToAction("Listar");


        }
    }



}