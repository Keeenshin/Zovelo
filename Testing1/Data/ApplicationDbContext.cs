using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Testing1.Models;

namespace Testing1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            // Updated Seed Data for Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Aria Bangle",
                    ImageUrls = "Aria Bangle/11.png,Aria Bangle/3.png,Aria Bangle/9.png",
                    Price = 20.00m,
                    Description = "A gold bangle featuring a sleek minimalist design, perfect for both casual and formal outfits.",
                    Type = "bangle",
                    BestSelling = true,
                    DateAdded = new DateTime(2024, 8, 20)
                },
                new Product
                {
                    Id = 2,
                    Name = "Bead Drop Earrings",
                    ImageUrls = "Bead Drop Earrings/10.png,Bead Drop Earrings/11.png,Bead Drop Earrings/12.png",
                    Price = 20.00m,
                    Description = "Elegant drop earrings adorned with polished gold beads, perfect for making a subtle statement.",
                    Type = "earrings",
                    BestSelling = true,
                    DateAdded = new DateTime(2024, 8, 20)
                },
                new Product
                {
                    Id = 3,
                    Name = "Bubble Bracelet",
                    ImageUrls = "Bubble Bracelet/1.png,Bubble Bracelet/2.png,Bubble Bracelet/3.png",
                    Price = 25.00m,
                    Description = "A playful bracelet with bubble-like gold beads, offering a light and joyful look.",
                    Type = "bracelet",
                    BestSelling = false,
                    DateAdded = new DateTime(2024, 8, 17)
                },
                new Product
                {
                    Id = 4,
                    Name = "Daisy Necklace",
                    ImageUrls = "Daisy Necklace/21.png,Daisy Necklace/22.png,Daisy Necklace/23.png",
                    Price = 25.00m,
                    Description = "A charming necklace featuring delicate daisy flowers, perfect for adding a playful touch to any outfit.",
                    Type = "necklace",
                    BestSelling = true,
                    DateAdded = new DateTime(2024, 8, 16)
                },
                new Product
                {
                    Id = 5,
                    Name = "Dome Ring",
                    ImageUrls = "Dome Ring/2.png,Dome Ring/3.png,Dome Ring/5.png",
                    Price = 20.00m,
                    Description = "A bold dome ring with a polished finish, ideal for adding a modern touch to your look.",
                    Type = "ring",
                    BestSelling = false,
                    DateAdded = new DateTime(2024, 8, 19)
                },
                new Product
                {
                    Id = 6,
                    Name = "Globe Earrings",
                    ImageUrls = "Globe Earrings/16.png,Globe Earrings/8.png,Globe Earrings/9.png",
                    Price = 25.00m,
                    Description = "Gold globe earrings offering a timeless and chic style, perfect for any occasion.",
                    Type = "earrings",
                    BestSelling = true,
                    DateAdded = new DateTime(2024, 8, 19)
                }
            );
        }

    }
}

