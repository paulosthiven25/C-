using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        [Required,StringLength(50)]
        public string Nome { get; set; }
        [Required,Range(0,999)]
        public int Crm { get; set; }
        public Especialidade Especialidade { get; set; }

        //Relacionamentos
        public IList<Consulta> Consultas { get; set; }
    }
}
