using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Repositories;
using _06_Fiap.Web.AspNet.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class ConsultaController : Controller
    {
        private IConsultaRepository _consultaRepository;
        private IMedicoRepository _medicoRepository;
        public ConsultaController(IConsultaRepository consultaRepository,IMedicoRepository medicoRepository)
        {
            _consultaRepository = consultaRepository;
            _medicoRepository = medicoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Agendar(int id)
        {
            var medico = _medicoRepository.BuscarPorId(id);
            var viewModel = new AgendamentoViewModel()
            {
                Medico = medico,
                Consulta = new Consulta() { MedicoId = id },
                NumeroConsultas = _consultaRepository.ContarPorMedico(id)
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Cadastrar(Consulta consulta)
        {
            
            _consultaRepository.Adicionar(consulta);
            _consultaRepository.Salvar();
            TempData["msg"] = "A consulta foi cadastrada";
            return RedirectToAction("Cadastrar");
            

        }
    }
}