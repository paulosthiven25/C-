using _04_Fiap.Web.Asp.net.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.Asp.net.Persistencia
{
    public class LocadoraContext : DbContext
    {
        public DbSet<Veiculo> Veiculos{ get; set; }

        public DbSet<Proprietario> Proprietarios  { get; set; }
        public LocadoraContext(DbContextOptions opts):base(opts)
        {

        }
    }
}
