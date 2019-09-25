using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.ProjetoRelacionamento.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public float Altura { get; set; }

        //relacionamento

        public Time Time { get; set; }

        public int TimeId { get; set; }


    }
}
