using _06_Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.ViewModels
{
    public class AgendamentoViewModel
    {
        public Medico Medico { get; set; }
        public Consulta Consulta { get; set; }

        public long NumeroConsultas { get; set; }
    }
}
