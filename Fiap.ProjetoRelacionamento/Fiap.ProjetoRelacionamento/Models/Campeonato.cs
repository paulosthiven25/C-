using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.ProjetoRelacionamento.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public decimal Premiacao { get; set; }
        public TipoCampeonato TipoCampeonato{ get; set; }

    public IList<CampeonatoTime> CampeonatoTime { get; set; }
}

}
