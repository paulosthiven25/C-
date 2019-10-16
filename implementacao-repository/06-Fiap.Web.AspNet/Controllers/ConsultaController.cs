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

        public ConsultaController(IConsultaRepository consultaRepository, IMedicoRepository medicoRepository)
        {
            _consultaRepository = consultaRepository;
            _medicoRepository = medicoRepository;
        }

        [HttpPost]
        public IActionResult Confirmar (int codigo)
        {
            var consulta = _consultaRepository.BuscarPorId(codigo);
            _consultaRepository.Confirmar(consulta);
            _consultaRepository.Salvar();
            TempData["msg"] = "Consulta confirmada";
            return RedirectToAction("Cadastrar", new { medico = consulta.MedicoId });
        }


        [HttpGet]
        public IActionResult Cadastrar(int medico)
        {
            var m = _medicoRepository.BuscarPorId(medico);
            var viewModel = new AgendamentoViewModel()
            {
                Medico = m,
                Consulta = new Consulta() { MedicoId = medico },
                NumeroConsultas = _consultaRepository.ContarPorMedico(medico),
                consultas = _consultaRepository.BuscarPor(c => c.Data > DateTime.Now)
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Cadastrar(Consulta consulta)
        {
            _consultaRepository.Inserir(consulta);
            _consultaRepository.Salvar();
            TempData["msg"] = "Agendado";
            return RedirectToAction("Cadastrar", new { medico = consulta.MedicoId });
        }
    }
}