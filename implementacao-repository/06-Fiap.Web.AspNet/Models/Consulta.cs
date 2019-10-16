using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        [Required(ErrorMessage = "Paciente é obrigatório"),StringLength(50)]
        public string Paciente { get; set; }
        public DateTime Data { get; set; }
        public bool Convenio { get; set; }
        public bool Confirmado { get; set; }

        //Relacionamento
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
    }
}
