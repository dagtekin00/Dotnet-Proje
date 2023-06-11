﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TacettinProje.Models;

#nullable disable

namespace TacettinProje.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230531074921_yeni")]
    partial class yeni
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TacettinProje.Models.gelenSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Paket")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("siparisler");
                });
#pragma warning restore 612, 618
        }
    }
}