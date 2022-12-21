using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FUO.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Order = table.Column<int>(type: "int", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Order = table.Column<int>(type: "int", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubIndicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Order = table.Column<int>(type: "int", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubIndicators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subsectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    EName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Order = table.Column<int>(type: "int", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsectors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "SubIndicators");

            migrationBuilder.DropTable(
                name: "Subsectors");
        }
    }
}
