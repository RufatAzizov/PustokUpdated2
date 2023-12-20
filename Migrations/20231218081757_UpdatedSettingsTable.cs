using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokMVC.Migrations
{
    public partial class UpdatedSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountIcon",
                table: "Settings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountIcon",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccountIcon",
                value: "<i class='fa fa-user-o'></i>");
        }
    }
}
