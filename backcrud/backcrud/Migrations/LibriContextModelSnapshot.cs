﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backcrud.Models;

#nullable disable

namespace backcrud.Migrations
{
    [DbContext(typeof(LibriContext))]
    partial class LibriContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backcrud.Models.Libri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Gjuha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lloji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrFaqeve")
                        .HasColumnType("int");

                    b.Property<int>("NrKopjeve")
                        .HasColumnType("int");

                    b.Property<string>("Titulli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VitiPublikimit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Librat");
                });
#pragma warning restore 612, 618
        }
    }
}
