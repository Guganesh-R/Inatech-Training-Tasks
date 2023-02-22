using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsole.Migrations
{
    /// <inheritdoc />
    public partial class Foreeginkey3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Standard_refID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Standard",
                table: "Standard");

            migrationBuilder.RenameTable(
                name: "Standard",
                newName: "standards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_standards",
                table: "standards",
                column: "StdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_standards_refID",
                table: "Students",
                column: "refID",
                principalTable: "standards",
                principalColumn: "StdId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_standards_refID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_standards",
                table: "standards");

            migrationBuilder.RenameTable(
                name: "standards",
                newName: "Standard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Standard",
                table: "Standard",
                column: "StdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Standard_refID",
                table: "Students",
                column: "refID",
                principalTable: "Standard",
                principalColumn: "StdId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
