using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing1.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "Bead Drop Earrings/10.png,Bead Drop Earrings/11.png,Bead Drop Earrings/12.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "Bead Drop Earrings/10.png,Bead Drop Earrings/10.png,Bead Drop Earrings/10.png");
        }
    }
}
