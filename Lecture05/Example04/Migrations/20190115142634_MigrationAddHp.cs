using Microsoft.EntityFrameworkCore.Migrations;

namespace Example04.Migrations
{
    public partial class MigrationAddHp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hp",
                table: "Pokemons");
        }
    }
}
