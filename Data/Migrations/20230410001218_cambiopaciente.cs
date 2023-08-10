using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicaDental01.Data.Migrations
{
    public partial class cambiopaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialMedicos");

            migrationBuilder.AddColumn<bool>(
                name: "Alergia",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AparicionDeEquimosisOMoretes",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ApoyalaManoSobreLaBarbilla",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChuponOChupeta",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ComeMuerdeObjetos",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiabetesTipo1",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DiabetesTipo2",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DueleAlAbrirOCerrarLaBoca",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DuermeConBocaAbiertaOCerrada",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadDeTransmisionSexual",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadesCardiacas",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnfermedadesRespiratorias",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EpilepsiaDesmayoConvulsiones",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstaOcreeEstarEmbarazada",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FiebreReumAtica",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fuma",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Hepatitis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Osteoporosis",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeLaPresionArterial",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeLaTiroides",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeMareos",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasDeVision",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasEnLosRinones",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProblemasGastrointestinales",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RastrillaLosDientes",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SacaLaLenguaOTieneLenguaProtractil",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShockAnafilactico",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SuccionDeDedo",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TomaLicor",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TratamientoAnticonceptivo",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TratamientoPsiquiatrico",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VIHOSIDA",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "VirusDelHerpes",
                table: "Pacientes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alergia",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "AparicionDeEquimosisOMoretes",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ApoyalaManoSobreLaBarbilla",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ChuponOChupeta",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ComeMuerdeObjetos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DiabetesTipo1",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DiabetesTipo2",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DueleAlAbrirOCerrarLaBoca",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "DuermeConBocaAbiertaOCerrada",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EnfermedadDeTransmisionSexual",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EnfermedadesCardiacas",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EnfermedadesRespiratorias",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EpilepsiaDesmayoConvulsiones",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "EstaOcreeEstarEmbarazada",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "FiebreReumAtica",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Fuma",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Hepatitis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Osteoporosis",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasDeLaPresionArterial",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasDeLaTiroides",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasDeMareos",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasDeVision",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasEnLosRinones",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ProblemasGastrointestinales",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "RastrillaLosDientes",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "SacaLaLenguaOTieneLenguaProtractil",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "ShockAnafilactico",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "SuccionDeDedo",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "TomaLicor",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "TratamientoAnticonceptivo",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "TratamientoPsiquiatrico",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "VIHOSIDA",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "VirusDelHerpes",
                table: "Pacientes");

            migrationBuilder.CreateTable(
                name: "HistorialMedicos",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alergia = table.Column<bool>(type: "bit", nullable: false),
                    AparicionDeEquimosisOMoretes = table.Column<bool>(type: "bit", nullable: false),
                    ApoyalaManoSobreLaBarbilla = table.Column<bool>(type: "bit", nullable: false),
                    ChuponOChupeta = table.Column<bool>(type: "bit", nullable: false),
                    ComeMuerdeObjetos = table.Column<bool>(type: "bit", nullable: false),
                    DiabetesTipo1 = table.Column<bool>(type: "bit", nullable: false),
                    DiabetesTipo2 = table.Column<bool>(type: "bit", nullable: false),
                    DueleAlAbrirOCerrarLaBoca = table.Column<bool>(type: "bit", nullable: false),
                    DuermeConBocaAbiertaOCerrada = table.Column<bool>(type: "bit", nullable: false),
                    EnfermedadDeTransmisionSexual = table.Column<bool>(type: "bit", nullable: false),
                    EnfermedadesCardiacas = table.Column<bool>(type: "bit", nullable: false),
                    EnfermedadesRespiratorias = table.Column<bool>(type: "bit", nullable: false),
                    EpilepsiaDesmayoConvulsiones = table.Column<bool>(type: "bit", nullable: false),
                    EstaOcreeEstarEmbarazada = table.Column<bool>(type: "bit", nullable: false),
                    FiebreReumAtica = table.Column<bool>(type: "bit", nullable: false),
                    Fuma = table.Column<bool>(type: "bit", nullable: false),
                    Hepatitis = table.Column<bool>(type: "bit", nullable: false),
                    IdHistorialMedico = table.Column<int>(type: "int", nullable: false),
                    Osteoporosis = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasDeLaPresionArterial = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasDeLaTiroides = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasDeMareos = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasDeVision = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasEnLosRinones = table.Column<bool>(type: "bit", nullable: false),
                    ProblemasGastrointestinales = table.Column<bool>(type: "bit", nullable: false),
                    RastrillaLosDientes = table.Column<bool>(type: "bit", nullable: false),
                    SacaLaLenguaOTieneLenguaProtractil = table.Column<bool>(type: "bit", nullable: false),
                    ShockAnafilactico = table.Column<bool>(type: "bit", nullable: false),
                    SuccionDeDedo = table.Column<bool>(type: "bit", nullable: false),
                    TomaLicor = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoAnticonceptivo = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoPsiquiatrico = table.Column<bool>(type: "bit", nullable: false),
                    VIHOSIDA = table.Column<bool>(type: "bit", nullable: false),
                    VirusDelHerpes = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialMedicos", x => x.IdPaciente);
                });
        }
    }
}
