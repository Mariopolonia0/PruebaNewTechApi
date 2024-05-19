﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaNewTechApi.DAL;

#nullable disable

namespace PruebaNewTechApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240519171311_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.29");

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

            modelBuilder.Entity("PruebaNewTechApi.Model.ControlTarea.Tarea", b =>
                {
                    b.Property<int>("tareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fechaCreada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fechaTerminada")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fechaVecimineto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("usuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("tareaId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("PruebaNewTechApi.Model.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            usuarioId = 100,
                            apellido = "admin",
                            nombre = "Super",
                            nombreUsuario = "admin",
                            password = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
