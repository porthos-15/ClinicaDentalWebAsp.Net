using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    public partial class ModificarTablaConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PacienteConsulta",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PacienteConsulta",
                table: "Consultas");
        }
    }
}
