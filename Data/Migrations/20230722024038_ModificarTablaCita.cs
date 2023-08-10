using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    public partial class ModificarTablaCita : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Citas");

            migrationBuilder.RenameColumn(
                name: "Tratamiento",
                table: "Consultas",
                newName: "TipoSangre");

            migrationBuilder.RenameColumn(
                name: "IdPaciente",
                table: "Consultas",
                newName: "Temperatura");

            migrationBuilder.RenameColumn(
                name: "IdDentista",
                table: "Consultas",
                newName: "TejidosBlandos");

            migrationBuilder.RenameColumn(
                name: "Diagnostico",
                table: "Consultas",
                newName: "QuejaPrincipal");

            migrationBuilder.RenameColumn(
                name: "IdServicio",
                table: "Citas",
                newName: "DescripcionCita");

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesAlergicos",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesPatologicos",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AntecedentesQuirurjicos",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergenciaLlamar",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estatura",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamenExtraoral",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrecuenciaRespiratoria",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HistorialDental",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MedicamentosToma",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MedicoCabecera",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlanTratamiento",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PresionArterial",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pulso",
                table: "Consultas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AntecedentesAlergicos",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "AntecedentesPatologicos",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "AntecedentesQuirurjicos",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "EmergenciaLlamar",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Estatura",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ExamenExtraoral",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "FrecuenciaRespiratoria",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "HistorialDental",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "MedicamentosToma",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "MedicoCabecera",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "PlanTratamiento",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "PresionArterial",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "Pulso",
                table: "Consultas");

            migrationBuilder.RenameColumn(
                name: "TipoSangre",
                table: "Consultas",
                newName: "Tratamiento");

            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "Consultas",
                newName: "IdPaciente");

            migrationBuilder.RenameColumn(
                name: "TejidosBlandos",
                table: "Consultas",
                newName: "IdDentista");

            migrationBuilder.RenameColumn(
                name: "QuejaPrincipal",
                table: "Consultas",
                newName: "Diagnostico");

            migrationBuilder.RenameColumn(
                name: "DescripcionCita",
                table: "Citas",
                newName: "IdServicio");

            migrationBuilder.AddColumn<string>(
                name: "IdPaciente",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
