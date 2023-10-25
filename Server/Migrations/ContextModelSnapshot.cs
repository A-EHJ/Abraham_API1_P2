﻿// <auto-generated />
using System;
using Abraham_API1_P2.Server.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Abraham_API1_P2.Server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.Entradas", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadProducida")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("PesoTotal")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.EntradasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CantidadUtilizada")
                        .HasColumnType("REAL");

                    b.Property<int>("EntradaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("EntradaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("EntradasDetalle");
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Existensia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripción = "Maní",
                            Existensia = 500L,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripción = "Pistacho",
                            Existensia = 500L,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripción = "Pasas",
                            Existensia = 500L,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripción = "Ciruelas",
                            Existensia = 500L,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripción = "Arándanos",
                            Existensia = 500L,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 6,
                            Descripción = "Mixto MPP 0.5L lb",
                            Existensia = 0L,
                            Tipo = 1
                        },
                        new
                        {
                            ProductoId = 7,
                            Descripción = "Mixto MPC 0.5L lb",
                            Existensia = 0L,
                            Tipo = 1
                        },
                        new
                        {
                            ProductoId = 8,
                            Descripción = "Mixto MPp 0.2L lb",
                            Existensia = 0L,
                            Tipo = 1
                        });
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.Entradas", b =>
                {
                    b.HasOne("Abraham_API1_P2.Shared.Models.Productos", null)
                        .WithMany("Entradas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.EntradasDetalle", b =>
                {
                    b.HasOne("Abraham_API1_P2.Shared.Models.Entradas", null)
                        .WithMany("EntradasDetalle")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abraham_API1_P2.Shared.Models.Productos", null)
                        .WithMany("EntradasDetalle")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.Entradas", b =>
                {
                    b.Navigation("EntradasDetalle");
                });

            modelBuilder.Entity("Abraham_API1_P2.Shared.Models.Productos", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("EntradasDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}