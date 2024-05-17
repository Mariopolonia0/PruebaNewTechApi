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
    [Migration("20220811000922_primera")]
    partial class primera
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
#pragma warning restore 612, 618
        }
    }
}
