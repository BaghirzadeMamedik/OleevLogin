using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K205Oleev.Migrations
{
    public partial class NewLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Infos");

            migrationBuilder.CreateTable(
                name: "CountDowns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountDowns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InfoLanguages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LangCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoLanguages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InfoLanguages_Infos_InfoID",
                        column: x => x.InfoID,
                        principalTable: "Infos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OurServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CountDownLanguages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LangCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountDownID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountDownLanguages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CountDownLanguages_CountDowns_CountDownID",
                        column: x => x.CountDownID,
                        principalTable: "CountDowns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OurServiceLanguages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LangCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurServiceID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurServiceLanguages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OurServiceLanguages_OurServices_OurServiceID",
                        column: x => x.OurServiceID,
                        principalTable: "OurServices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountDownLanguages_CountDownID",
                table: "CountDownLanguages",
                column: "CountDownID");

            migrationBuilder.CreateIndex(
                name: "IX_InfoLanguages_InfoID",
                table: "InfoLanguages",
                column: "InfoID");

            migrationBuilder.CreateIndex(
                name: "IX_OurServiceLanguages_OurServiceID",
                table: "OurServiceLanguages",
                column: "OurServiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountDownLanguages");

            migrationBuilder.DropTable(
                name: "InfoLanguages");

            migrationBuilder.DropTable(
                name: "OurServiceLanguages");

            migrationBuilder.DropTable(
                name: "CountDowns");

            migrationBuilder.DropTable(
                name: "OurServices");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Infos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
