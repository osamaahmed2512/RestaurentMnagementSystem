using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurentMnagemntSytem.Data.Migrations
{
    /// <inheritdoc />
    public partial class up_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Category");
        }
    }
}
