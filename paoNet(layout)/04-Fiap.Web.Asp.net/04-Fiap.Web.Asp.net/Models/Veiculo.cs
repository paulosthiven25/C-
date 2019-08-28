using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.Asp.net.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        [Column("cd_veiculo")]
        public int Codigo { get; set; }
        [Column("vl_Peso")]
        public float Peso { get; set; }
        [Column("ds_modelo"),Required,MaxLength(100)]
        public string Modelo { get; set; }
        [Display(Name="Data Fabricação"),DataType(DataType.Date)]

        [Column("dt_fabricacao"), Required]
        public DateTime DataFabricacao { get; set; }
        [Column("tp_combustivel")]
        public Combustivel TipoCombustivel { get; set; }
    }
}
