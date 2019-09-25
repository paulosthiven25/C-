using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.ProjetoRelacionamento.Models;
using Fiap.ProjetoRelacionamento.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fiap.ProjetoRelacionamento.Controllers
{
    public class JogadorController : Controller
    {
        private Context _context;
        public JogadorController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar(int id)
        {
            CarregarSelectTimes();

            var jogador = new Jogador()
            {
                DataNascimento = DateTime.Now,
                TimeId = id 
            };
            
            return View(jogador);
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogador jogador)
        {
            
            _context.jogadores.Add(jogador);
            _context.SaveChanges();

            TempData["msg"] = "O jogador," + jogador.Nome + " foi cadastrado";
          

            return RedirectToAction("Cadastrar");
        }

        private void CarregarSelectTimes()
        {
            var lista = _context.Times.ToList();
            ViewBag.times = new SelectList(lista, "Codigo", "Nome");
        }

        [HttpGet]
        public IActionResult Listar(int timeBusca)
        {
            CarregarSelectTimes();

            return View(_context.jogadores.Include(Jogador => Jogador.Time)
                .Where(Jogador => Jogador.TimeId == timeBusca || timeBusca == 0).ToList());
        }

       
    }
}