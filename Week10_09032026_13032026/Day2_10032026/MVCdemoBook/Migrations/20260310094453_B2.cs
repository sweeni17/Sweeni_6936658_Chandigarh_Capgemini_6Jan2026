using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCdemoBook.Migrations
{
    /// <inheritdoc />
    public partial class B2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "tblBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblBooks",
                table: "tblBooks",
                column: "BookModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblBooks",
                table: "tblBooks");

            migrationBuilder.RenameTable(
                name: "tblBooks",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookModelId");
        }
    }
}
