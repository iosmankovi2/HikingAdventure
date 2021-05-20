﻿// <auto-generated />
using System;
using Hiking_Adventures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hiking_Adventures.Migrations.Data2
{
    [DbContext(typeof(Data2Context))]
    [Migration("20210519151733_migrcia5")]
    partial class migrcia5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Hiking_Adventures.Models.PrijavaRute", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime");

                    b.Property<string>("Ime")
                        .HasColumnType("text");

                    b.Property<string>("Prezime")
                        .HasColumnType("text");

                    b.Property<string>("eMail")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("PrijaveRuta");
                });
#pragma warning restore 612, 618
        }
    }
}
