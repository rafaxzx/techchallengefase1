using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechChallengeFase1.Migrations
{
    /// <inheritdoc />
    public partial class QuartaAjusteindiceDDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ddd_Number",
                table: "ddd",
                column: "Number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ddd_Number",
                table: "ddd");
        }
    }
}
