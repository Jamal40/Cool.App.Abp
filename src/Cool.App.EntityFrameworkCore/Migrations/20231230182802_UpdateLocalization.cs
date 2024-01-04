using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cool.App.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLocalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "LocalizationItems",
                newName: "Message");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "LocalizationItems",
                newName: "Value");
        }
    }
}
