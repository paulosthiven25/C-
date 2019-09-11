using Fiap.ProjetoRelacionamento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.ProjetoRelacionamento.Persistencia
{
    public class Context : DbContext
    {
        public DbSet<Time> Times { get; set; }

        public Context(DbContextOptions opts) : base(opts)
        {

        }

    }
}
