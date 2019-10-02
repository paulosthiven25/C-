using _06_Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Repositories
{
    public interface IMedicoRepository
    {
        void Adicionar(Medico medico);
        void Excluir(int id);
        void Atualizar(Medico medico);
        Medico BuscarPorId(int id);
        IList<Medico> Listar();
        void Salvar();
        IList<Medico> BuscarPor(Expression<Func<Medico,bool>> filtro);
    }
}
