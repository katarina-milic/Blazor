﻿// <auto-generated />
using System;
using Blazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blazor.Server.Migrations
{
    [DbContext(typeof(FilmContext))]
    [Migration("20200207124736_Baza")]
    partial class Baza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blazor.Shared.DatumProjekcije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Projekcije");
                });

            modelBuilder.Entity("Blazor.Shared.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zanr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filmovi");
                });

            modelBuilder.Entity("Blazor.Shared.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("Blazor.Shared.Sediste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<int?>("RezervacijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RezervacijaId");

                    b.ToTable("Sediste");
                });

            modelBuilder.Entity("Blazor.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Blazor.Shared.DatumProjekcije", b =>
                {
                    b.HasOne("Blazor.Shared.Film", null)
                        .WithMany("Projekcije")
                        .HasForeignKey("FilmId");
                });

            modelBuilder.Entity("Blazor.Shared.Rezervacija", b =>
                {
                    b.HasOne("Blazor.Shared.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blazor.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blazor.Shared.Sediste", b =>
                {
                    b.HasOne("Blazor.Shared.Rezervacija", null)
                        .WithMany("Sedista")
                        .HasForeignKey("RezervacijaId");
                });
#pragma warning restore 612, 618
        }
    }
}
