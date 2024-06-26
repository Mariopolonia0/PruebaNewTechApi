﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaNewTechApi.DAL;

#nullable disable

namespace PruebaNewTechApi.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("PruebaNewTechApi.Model.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Edicion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreAutor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 100,
                            Edicion = "Tercera",
                            Nombre = "El Coronel no tiene quien le escriba",
                            NombreAutor = "Grabriel Garcia Marquez",
                            Precio = 1000m
                        });
                });

            modelBuilder.Entity("PruebaNewTechApi.Model.Licencia", b =>
                {
                    b.Property<int>("LicenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CostoLicencia")
                        .HasColumnType("REAL");

                    b.Property<string>("DireccionCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroLicencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LicenciaId");

                    b.ToTable("Licencias");

                    b.HasData(
                        new
                        {
                            LicenciaId = 100,
                            CostoLicencia = 200.0,
                            DireccionCliente = "575w 189st",
                            NombreCliente = "",
                            NumeroLicencia = "SP"
                        });
                });

            modelBuilder.Entity("PruebaNewTechApi.Model.Tarea", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaCreada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaTerminada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FechaVecimineto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TareaId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("PruebaNewTechApi.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroLicencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 100,
                            Apellido = "admin",
                            Nombre = "Super",
                            NombreUsuario = "admin",
                            NumeroLicencia = "SP",
                            Password = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
