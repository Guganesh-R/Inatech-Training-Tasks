using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsole.Migrations
{
    /// <inheritdoc />
    public partial class Foreeginkey1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standard_StandardStdId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StandardStdId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StandardStdId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_refID",
                table: "Students",
                column: "refID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standard_refID",
                table: "Students",
                column: "refID",
                principalTable: "Standard",
                principalColumn: "StdId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standard_refID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_refID",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StandardStdId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StandardStdId",
                table: "Students",
                column: "StandardStdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standard_StandardStdId",
                table: "Students",
                column: "StandardStdId",
                principalTable: "Standard",
                principalColumn: "StdId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
