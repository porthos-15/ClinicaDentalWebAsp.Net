using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    IdCita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdServicio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.IdCita);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    IdConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tratamiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDentista = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.IdConsulta);
                });

            migrationBuilder.CreateTable(
                name: "Dentistas",
                columns: table => new
                {
                    IdDentista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDentista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellidoDentista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellidoDentista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoDentista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoDentista = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentistas", x => x.IdDentista);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaPaciente = table.Column<int>(type: "int", nullable: false),
                    NombrePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellidoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellidoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimientoPaciente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DireccionPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostoServicio = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdServicio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Dentistas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
