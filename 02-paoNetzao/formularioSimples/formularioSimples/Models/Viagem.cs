using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace formularioSimples.Models
{
    public class Viagem
    {
        public string Destino { get; set; }
        public bool Internacional { get; set; }

        [Display(Name="Data de Saída")]
        public DateTime DataSaida { get; set; }

        public decimal Valor { get; set; }

        public TipoViagem TipoViagem { get; set; }
    }
}
