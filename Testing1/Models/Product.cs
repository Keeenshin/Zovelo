
namespace Testing1.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; 
    public string Description { get; set; } = string.Empty; 
    public decimal Price { get; set; }
    public string ImageUrls { get; set; } = string.Empty; 
    public string Type { get; set; } = string.Empty; 
    public bool BestSelling { get; set; }
    public DateTime DateAdded { get; set; }
}
