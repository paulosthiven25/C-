﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _06_Fiap.Web.AspNet.Contexts;

namespace _06_Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(ClinicaContext))]
    [Migration("20191002130818_Clinica")]
    partial class Clinica
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Consulta", b =>
                {
                    b.Property<int>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirmado");

                    b.Property<bool>("Convenio");

                    b.Property<DateTime>("Data");

                    b.Property<int>("MedicoId");

                    b.Property<string>("Paciente");

                    b.HasKey("ConsultaId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Medico", b =>
                {
                    b.Property<int>("MedicoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Crm");

                    b.Property<int>("Especialidade");

                    b.Property<string>("Nome");

                    b.HasKey("MedicoId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("_06_Fiap.Web.AspNet.Models.Consulta", b =>
                {
                    b.HasOne("_06_Fiap.Web.AspNet.Models.Medico", "Medico")
                        .WithMany("Consultas")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
