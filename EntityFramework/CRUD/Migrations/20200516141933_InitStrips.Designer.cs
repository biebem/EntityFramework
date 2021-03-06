﻿// <auto-generated />
using System;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations
{
    [DbContext(typeof(StripContext))]
    [Migration("20200516141933_InitStrips")]
    partial class InitStrips
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD.Data.Auteur", b =>
                {
                    b.Property<int>("AuteurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuteurID");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("CRUD.Data.AuteurStrip", b =>
                {
                    b.Property<int>("StripID")
                        .HasColumnType("int");

                    b.Property<int>("AuteurID")
                        .HasColumnType("int");

                    b.HasKey("StripID", "AuteurID");

                    b.HasIndex("AuteurID");

                    b.ToTable("AuteurStrip");
                });

            modelBuilder.Entity("CRUD.Data.Reeks", b =>
                {
                    b.Property<int>("ReeksID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReeksID");

                    b.ToTable("Reeksen");
                });

            modelBuilder.Entity("CRUD.Data.Strip", b =>
                {
                    b.Property<int>("StripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nr")
                        .HasColumnType("int");

                    b.Property<int?>("ReeksID")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UitgeverijID")
                        .HasColumnType("int");

                    b.HasKey("StripID");

                    b.HasIndex("ReeksID");

                    b.HasIndex("UitgeverijID");

                    b.ToTable("Strips");
                });

            modelBuilder.Entity("CRUD.Data.Uitgeverij", b =>
                {
                    b.Property<int>("UitgeverijID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UitgeverijID");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("CRUD.Data.AuteurStrip", b =>
                {
                    b.HasOne("CRUD.Data.Auteur", "Auteur")
                        .WithMany("StripsLink")
                        .HasForeignKey("AuteurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRUD.Data.Strip", "Strip")
                        .WithMany("AuteursLink")
                        .HasForeignKey("StripID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRUD.Data.Strip", b =>
                {
                    b.HasOne("CRUD.Data.Reeks", "Reeks")
                        .WithMany("Strips")
                        .HasForeignKey("ReeksID");

                    b.HasOne("CRUD.Data.Uitgeverij", "Uitgever")
                        .WithMany()
                        .HasForeignKey("UitgeverijID");
                });
#pragma warning restore 612, 618
        }
    }
}
