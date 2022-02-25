using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K205Oleev.Migrations
{
    public partial class NewLang2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SEO",
                table: "OurServiceLanguages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEO",
                table: "InfoLanguages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SEO",
                table: "AboutLanguages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SEO",
                table: "OurServiceLanguages");

            migrationBuilder.DropColumn(
                name: "SEO",
                table: "InfoLanguages");

            migrationBuilder.DropColumn(
                name: "SEO",
                table: "AboutLanguages");
        }
    }
}
