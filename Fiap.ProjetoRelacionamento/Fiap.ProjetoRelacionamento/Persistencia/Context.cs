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
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Jogador> jogadores{ get; set; }
        public DbSet<Treinador> Treinadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a tabela associativa
            //configurar as chaves da tabela
            modelBuilder.Entity<CampeonatoTime>().
                HasKey(c => new { c.CampeonatoId,c.TimeId});
            //Configurar o relacionamento com o Campeonato
            modelBuilder.Entity<CampeonatoTime>()
                .HasOne(c => c.Campeonato)
                .WithMany(c => c.CampeonatoTime)
                .HasForeignKey(c => c.CampeonatoId);

            //Configurar o relacionamento com o Time
            modelBuilder.Entity<CampeonatoTime>()
                .HasOne(c => c.Time)
                .WithMany(c => c.CampeonatoTime)
                .HasForeignKey(c => c.TimeId);



            base.OnModelCreating(modelBuilder);
        }

        public Context(DbContextOptions opts) : base(opts)
        {

        }

    }
}
