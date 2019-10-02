using _06_Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Repositories
{
  public interface IConsultaRepository
    {
        long ContarPorMedico(int id);
        void Adicionar(Consulta medico);
        void Excluir(int id);
        void Atualizar(Consulta medico);
        Consulta BuscarPorId(int id);
        IList<Consulta> Listar();
        void Salvar();
        IList<Consulta> BuscarPor(Expression<Func<Consulta, bool>> filtro);
    }
}
