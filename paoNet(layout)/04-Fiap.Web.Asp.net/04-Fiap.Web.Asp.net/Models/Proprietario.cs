using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.Asp.net.Models
{
    public class Proprietario
    {
        [Key]
        [Column("cd_proprietario"),HiddenInput]
        public int Codigo { get; set; }

        [Column("nm_proprietario")]
        public string Nome { get; set; }
        [Column("st_deficiente")]
        public bool Deficiente { get; set; }
    }
}
