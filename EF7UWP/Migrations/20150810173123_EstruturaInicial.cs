using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace EF7UWPMigrations
{
    public partial class EstruturaInicial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    idPessoa = table.Column(type: "INTEGER", nullable: false),
                    nome = table.Column(type: "TEXT", nullable: false),
                    telefone = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.idPessoa);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Pessoa");
        }
    }
}
