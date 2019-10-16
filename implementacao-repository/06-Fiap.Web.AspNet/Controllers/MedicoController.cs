using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Models;
using _06_Fiap.Web.AspNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class MedicoController : Controller
    {
        private IMedicoRepository _repository;

        public MedicoController(IMedicoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Medico medico)
        {
            _repository.Adicionar(medico);
            _repository.Salvar();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_repository.Listar());
        }
    }
}