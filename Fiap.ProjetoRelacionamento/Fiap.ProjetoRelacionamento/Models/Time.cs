﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.ProjetoRelacionamento.Models
{
    public class Time
    {   [Key,HiddenInput]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public bool Mascote { get; set; }
        public Esporte Esporte { get; set; }

        //relacionamento

        public Treinador Tecnico { get; set; }
        public int TreinadorId { get; set; }

        public IList<Jogador> Jogadores { get; set; }

        public IList<CampeonatoTime> CampeonatoTime { get; set; }
    }
}
