﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Testowy.Models;

namespace Testowy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200114092151_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Testowy.Models.Samochod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("JestSamochodemTygodnia")
                        .HasColumnType("bit");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miniaturka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Moc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pojemnosc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Przebieg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RodzajPaliwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RokProdukcji")
                        .HasColumnType("int");

                    b.Property<string>("Zdjecie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("samochody");
                });
#pragma warning restore 612, 618
        }
    }
}
