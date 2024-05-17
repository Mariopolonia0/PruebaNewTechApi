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
    [Migration("20240517012844_inicial_1")]
    partial class inicial_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            BookId = 101,
                            Edicion = "Primera",
                            Nombre = "El lenguaje de programacion C#",
                            NombreAutor = "Francisco Javier Ceballos",
                            Precio = 10000m
                        },
                        new
                        {
                            BookId = 103,
                            Edicion = "Tercera",
                            Nombre = "Kotlin in Action",
                            NombreAutor = "Dmitry Jemerov and Svetlana Isakova",
                            Precio = 13000m
                        },
                        new
                        {
                            BookId = 104,
                            Edicion = "Tercera",
                            Nombre = "Java 2 Manual de programacion",
                            NombreAutor = "Luis Joyanes Aguilar",
                            Precio = 9000m
                        });
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