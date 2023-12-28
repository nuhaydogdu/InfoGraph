using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoGraphX_API.Migrations
{
    /// <inheritdoc />
    public partial class umut_ucuncu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HappinesRates");
        }
    }
}
