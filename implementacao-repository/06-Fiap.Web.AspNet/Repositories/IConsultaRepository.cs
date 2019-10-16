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

        void Confirmar(Consulta consulta);
        void Inserir(Consulta consulta);
        void Alterar(Consulta consulta);
        void Remover(int codigo);
        Consulta BuscarPorId(int codigo);
        IList<Consulta> Listar();
        IList<Consulta> BuscarPor(Expression<Func<Consulta, bool>> filtro);
        void Salvar();
    }
}
