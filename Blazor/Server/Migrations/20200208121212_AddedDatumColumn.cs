using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor.Server.Migrations
{
    public partial class AddedDatumColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DatumId",
                table: "Rezervacije",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_DatumId",
                table: "Rezervacije",
                column: "DatumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacije_Projekcije_DatumId",
                table: "Rezervacije",
                column: "DatumId",
                principalTable: "Projekcije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacije_Projekcije_DatumId",
                table: "Rezervacije");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacije_DatumId",
                table: "Rezervacije");

            migrationBuilder.DropColumn(
                name: "DatumId",
                table: "Rezervacije");
        }
    }
}
