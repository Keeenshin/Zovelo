using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Testing1.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BestSelling = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BestSelling", "DateAdded", "Description", "ImageUrls", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.", "Aria Bangle/11.png,Aria Bangle/3.png,Aria Bangle/9.png", "Aria Bangle", 20.00m, "bangle" },
                    { 2, false, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish gold bracelet with a series of polished beads, perfect for both casual and formal wear.", "Bead Drop Earrings/10.png,Bead Drop Earrings/10.png,Bead Drop Earrings/10.png", "Bead Drop Earrings", 20.00m, "earrings" },
                    { 3, false, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stylish gold bracelet with a series of polished beads, perfect for both casual and formal wear.", "Bubble Bracelet/1.png,Bubble Bracelet/2.png,Bubble Bracelet/3.png", "Bubble Bracelet", 25.00m, "bracelet" },
                    { 4, true, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.", "Daisy Necklace/21.png,Daisy Necklace/22.png,Daisy Necklace/23.png", "Daisy Necklace", 25.00m, "necklace" },
                    { 5, false, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.", "Dome Ring/2.png,Dome Ring/3.png,Dome Ring/5.png", "Dome Ring", 20.00m, "ring" },
                    { 6, false, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A charming gold necklace featuring delicate daisy flowers with white petals and vibrant yellow centers, perfect for adding a playful touch to any outfit.", "Globe Earrings/16.png,Globe Earrings/8.png,Globe Earrings/9.png", "Globe Earrings", 25.00m, "earrings" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
