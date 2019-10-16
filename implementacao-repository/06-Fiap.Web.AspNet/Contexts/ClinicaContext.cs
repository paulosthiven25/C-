using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Contexts
{
    public class ClinicaContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        public ClinicaContext(DbContextOptions o) : base(o)
        {

        }
    }
}
