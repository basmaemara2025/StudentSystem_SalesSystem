using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAlterColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
         name: "Description",
         table: "Products",
         type: "nvarchar(250)",
         maxLength: 250,
         nullable: false,
         defaultValue: "No Description",
         oldClrType: typeof(string),
         oldType: "nvarchar(250)",
         oldMaxLength: 250);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
