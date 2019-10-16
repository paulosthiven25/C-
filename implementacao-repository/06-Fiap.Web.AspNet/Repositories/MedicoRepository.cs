using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _06_Fiap.Web.AspNet.Contexts;
using _06_Fiap.Web.AspNet.Models;

namespace _06_Fiap.Web.AspNet.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private ClinicaContext _context;

        public MedicoRepository(ClinicaContext context)
        {
            _context = context;
        }

        public void Adicionar(Medico medico)
        {
            _context.Medicos.Add(medico);
        }

        public void Atualizar(Medico medico)
        {
            _context.Medicos.Update(medico);
        }

        public IList<Medico> BuscarPor(Expression<Func<Medico, bool>> filtro)
        {            
            return _context.Medicos.Where(filtro).ToList();
        }

        public Medico BuscarPorId(int id)
        {
            return _context.Medicos.Find(id);
        }

        public void Excluir(int id)
        {
            var medico = _context.Medicos.Find(id);
            _context.Medicos.Remove(medico);
        }

        public IList<Medico> Listar()
        {
            return _context.Medicos.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
