using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KasaDefteriApp.Migrations
{
    /// <inheritdoc />
    public partial class FinalInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kasalar",
                columns: table => new
                {
                    KasaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KasaName = table.Column<string>(type: "TEXT", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasalar", x => x.KasaID);
                });

            migrationBuilder.CreateTable(
                name: "Islemler",
                columns: table => new
                {
                    IslemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IslemName = table.Column<string>(type: "TEXT", nullable: false),
                    IslemType = table.Column<int>(type: "INTEGER", nullable: false),
                    IslemAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    IslemDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KasaID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islemler", x => x.IslemID);
                    table.ForeignKey(
                        name: "FK_Islemler_Kasalar_KasaID",
                        column: x => x.KasaID,
                        principalTable: "Kasalar",
                        principalColumn: "KasaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Islemler_KasaID",
                table: "Islemler",
                column: "KasaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Islemler");

            migrationBuilder.DropTable(
                name: "Kasalar");
        }
    }
}
