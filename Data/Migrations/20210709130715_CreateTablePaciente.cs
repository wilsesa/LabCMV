using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabCMV.Data.Migrations
{
    public partial class CreateTablePaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeClinica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomePaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SobrenomePaciente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataRecebido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntregue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
