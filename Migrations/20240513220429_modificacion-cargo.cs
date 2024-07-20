using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TerminalV1.Migrations
{
    /// <inheritdoc />
    public partial class modificacioncargo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_oCargo",
                table: "oCargo");

            migrationBuilder.RenameTable(
                name: "oCargo",
                newName: "Cargo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cargo",
                table: "Cargo",
                column: "IdCargo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cargo",
                table: "Cargo");

            migrationBuilder.RenameTable(
                name: "Cargo",
                newName: "oCargo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_oCargo",
                table: "oCargo",
                column: "IdCargo");
        }
    }
}
