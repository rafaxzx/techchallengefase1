using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechChallengeFase1.Migrations
{
    /// <inheritdoc />
    public partial class TerceiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_ddd_Id",
                table: "contato");

            migrationBuilder.CreateIndex(
                name: "IX_contato_DDDId",
                table: "contato",
                column: "DDDId");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_ddd_DDDId",
                table: "contato",
                column: "DDDId",
                principalTable: "ddd",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contato_ddd_DDDId",
                table: "contato");

            migrationBuilder.DropIndex(
                name: "IX_contato_DDDId",
                table: "contato");

            migrationBuilder.AddForeignKey(
                name: "FK_contato_ddd_Id",
                table: "contato",
                column: "Id",
                principalTable: "ddd",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
