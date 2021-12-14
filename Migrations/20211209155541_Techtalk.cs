using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresNsql.Migrations
{
    public partial class Techtalk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idade",
                table: "data_models",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "data_models",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idade",
                table: "data_models");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "data_models");
        }
    }
}
