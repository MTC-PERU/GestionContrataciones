using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MTC.Persistence.Database.Migrations
{
    public partial class Add_initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombres = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido_Paterno = table.Column<string>(maxLength: 100, nullable: false),
                    Apellido_Materno = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(maxLength: 200, nullable: true),
                    Perfil = table.Column<string>(maxLength: 300, nullable: true),
                    Experiencia_General = table.Column<string>(maxLength: 500, nullable: true),
                    Experiencia_Especifica = table.Column<string>(maxLength: 500, nullable: true),
                    EsCoordinador = table.Column<bool>(nullable: false),
                    Dni = table.Column<string>(maxLength: 8, nullable: false),
                    Ruc = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    CCI = table.Column<string>(maxLength: 50, nullable: true),
                    Nro_Celular = table.Column<string>(maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "TerminoReferencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Objeto = table.Column<string>(maxLength: 500, nullable: true),
                    FinalidadPublica = table.Column<string>(maxLength: 500, nullable: true),
                    DuracionServicio = table.Column<string>(maxLength: 50, nullable: true),
                    FormaPago = table.Column<string>(maxLength: 50, nullable: true),
                    Sueldo = table.Column<decimal>(nullable: false),
                    ImporteTotal = table.Column<decimal>(nullable: false),
                    NumRequerimiento = table.Column<int>(nullable: false),
                    NumOrdenServicio = table.Column<string>(maxLength: 500, nullable: true),
                    NumSIAF = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    DocRetencion = table.Column<string>(nullable: true),
                    DocSunedu = table.Column<string>(nullable: true),
                    DocSeguro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminoReferencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    ApellidoPaterno = table.Column<string>(maxLength: 100, nullable: false),
                    ApellidoMaterno = table.Column<string>(maxLength: 100, nullable: false),
                    DNI = table.Column<string>(maxLength: 8, nullable: false),
                    RUC = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "TerminoReferencia");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
