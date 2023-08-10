using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    public partial class historial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<bool>(
                name: "Alergia",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AparicionDeEquimosisOMoretes",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiabetesTipo1",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiabetesTipo2",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DueleAlAbrirOCerrarLaBoca",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadDeTransmisionSexual",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadesCardiacas",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadesRespiratorias",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EpilepsiaDesmayoConvulsiones",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstaOcreeEstarEmbarazada",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FiebreReumAtica",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fuma",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Hepatitis",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "IdHistorialMedico",
                table: "HistorialMedicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Osteoporosis",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeLaPresionArterial",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeLaTiroides",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeMareos",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeVision",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasEnLosRinones",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasGastrointestinales",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SacaLaLenguaOTieneLenguaProtractil",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShockAnafilactico",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TomaLicor",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TratamientoAnticonceptivo",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TratamientoPsiquiatrico",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VIHOSIDA",
                table: "HistorialMedicos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alergia",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "AparicionDeEquimosisOMoretes",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "DiabetesTipo1",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "DiabetesTipo2",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "DueleAlAbrirOCerrarLaBoca",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "EnfermedadDeTransmisionSexual",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "EnfermedadesCardiacas",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "EnfermedadesRespiratorias",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "EpilepsiaDesmayoConvulsiones",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "EstaOcreeEstarEmbarazada",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "FiebreReumAtica",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "Fuma",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "Hepatitis",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "IdHistorialMedico",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "Osteoporosis",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasDeLaPresionArterial",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasDeLaTiroides",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasDeMareos",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasDeVision",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasEnLosRinones",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ProblemasGastrointestinales",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "SacaLaLenguaOTieneLenguaProtractil",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "ShockAnafilactico",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "TomaLicor",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "TratamientoAnticonceptivo",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "TratamientoPsiquiatrico",
                table: "HistorialMedicos");

            migrationBuilder.DropColumn(
                name: "VIHOSIDA",
                table: "HistorialMedicos");

            migrationBuilder.RenameColumn(
                name: "VirusDelHerpes",
                table: "HistorialMedicos",
                newName: "SacaLaLenguaOTieneLenguaProtráctil");
        }
    }
}
