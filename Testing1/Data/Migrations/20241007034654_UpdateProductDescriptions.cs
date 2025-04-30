using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Testing1.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductDescriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A gold bangle featuring a sleek minimalist design, perfect for both casual and formal outfits.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Elegant drop earrings adorned with polished gold beads, perfect for making a subtle statement.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A playful bracelet with bubble-like gold beads, offering a light and joyful look.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A charming necklace featuring delicate daisy flowers, perfect for adding a playful touch to any outfit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A bold dome ring with a polished finish, ideal for adding a modern touch to your look.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Gold globe earrings offering a timeless and chic style, perfect for any occasion.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "A stylish gold bracelet with a series of polished beads, perfect for both casual and formal wear.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A stylish gold bracelet with a series of polished beads, perfect for both casual and formal wear.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.");
        }
    }
}
