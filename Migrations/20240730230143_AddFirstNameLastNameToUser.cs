using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CampsiteReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstNameLastNameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "lastName");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstName",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "User",
                newName: "Username");
        }
    }
}
