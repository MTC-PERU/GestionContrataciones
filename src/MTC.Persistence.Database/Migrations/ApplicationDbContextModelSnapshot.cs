﻿// <auto-generated />
using MTC.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MTC.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MTC.Model.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasColumnType("character varying(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("RUC")
                        .IsRequired()
                        .HasColumnType("character varying(11)")
                        .HasMaxLength(11);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
