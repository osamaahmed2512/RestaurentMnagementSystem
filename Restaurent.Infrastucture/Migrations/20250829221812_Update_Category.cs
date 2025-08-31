using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMnagemntSytem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Category");
        }
    }
}
