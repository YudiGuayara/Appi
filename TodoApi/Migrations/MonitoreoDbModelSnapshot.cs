﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TodoApi.Data;

#nullable disable

namespace TodoApi.Migrations
{
    [DbContext(typeof(MonitoreoDb))]
    partial class MonitoreoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Alerta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdEvento")
                        .HasColumnType("integer");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<string>("Mensaje")
                        .HasColumnType("text");

                    b.Property<string>("Nivel")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Alertas");
                });

            modelBuilder.Entity("Contaminante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Carga")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contaminantes");
                });

            modelBuilder.Entity("Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdContaminante")
                        .HasColumnType("integer");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("integer");

                    b.Property<int>("Magnitud")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Medicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdContaminante")
                        .HasColumnType("integer");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("integer");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<decimal>("Ph")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Temperatura")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Mediciones");
                });

            modelBuilder.Entity("Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Latitud")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Longitud")
                        .HasColumnType("numeric");

                    b.Property<string>("Nombre")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Recursos");
                });
#pragma warning restore 612, 618
        }
    }
}
