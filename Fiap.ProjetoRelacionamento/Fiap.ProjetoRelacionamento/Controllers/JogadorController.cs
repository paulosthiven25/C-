using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiap.ProjetoRelacionamento.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Cadastrar()
        {
            ViewBag.teste = new SelectList(_context.Times.ToList(),"Codigo", "Nome");
            return View();
        }
    }
}