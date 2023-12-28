using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoGraphX_API.Migrations
{
    /// <inheritdoc />
    public partial class umut_ikinci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeGroup",
                table: "HappinessLevelByAgeGroups");

            migrationBuilder.DropColumn(
                name: "Happy",
                table: "HappinessLevelByAgeGroups");

            migrationBuilder.DropColumn(
                name: "Medium",
                table: "HappinessLevelByAgeGroups");

            migrationBuilder.DropColumn(
                name: "UnHappy",
                table: "HappinessLevelByAgeGroups");

            migrationBuilder.AddColumn<int>(
                name: "HappinesRatesId",
                table: "HappinessLevelByAgeGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HappinesRatesId",
                table: "HappinessLevelByAgeGroups");

            migrationBuilder.AddColumn<string>(
                name: "AgeGroup",
                table: "HappinessLevelByAgeGroups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Happy",
                table: "HappinessLevelByAgeGroups",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Medium",
                table: "HappinessLevelByAgeGroups",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UnHappy",
                table: "HappinessLevelByAgeGroups",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
