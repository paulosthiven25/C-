using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private ClinicaContext _context;

        public ConsultaRepository(ClinicaContext context)
        {
            _context = context;   
        }
        public void Adicionar(Consulta consulta)
        {
            _context.Consultas.Add(consulta);
        }

        public void Atualizar(Consulta consulta)
        {
            _context.Consultas.Update(consulta);
        }

        public IList<Consulta> BuscarPor(Expression<Func<Consulta, bool>> filtro)
        {
            return _context.Consultas.Where(filtro).ToList();
        }

        public Consulta BuscarPorId(int id)
        {
            return _context.Consultas.Find(id);
        }

        public void Excluir(int id)
        {
            var medico = _context.Consultas.Find(id);
            _context.Consultas.Remove(medico);
        }

        public IList<Consulta> Listar()
        {
            return _context.Consultas.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

       public long ContarPorMedico(int id)
        {
            return _context.Consultas.Where(m => m.MedicoId == id).Count();
        }
    }
}
