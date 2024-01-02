using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoGraphX_API.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForeignTradeValueIndices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExportUniteValue = table.Column<float>(type: "real", nullable: false),
                    ImportUniteValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignTradeValueIndices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HappinesRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HappyRate = table.Column<int>(type: "int", nullable: false),
                    MediumRate = table.Column<int>(type: "int", nullable: false),
                    UpsetRate = table.Column<int>(type: "int", nullable: false),
                    AgeInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HappinesRatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HappinesRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HappinessLevelByAgeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    HappinesRatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HappinessLevelByAgeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewedTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForeignTradeValueIndices");

            migrationBuilder.DropTable(
                name: "HappinesRates");

            migrationBuilder.DropTable(
                name: "HappinessLevelByAgeGroups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
