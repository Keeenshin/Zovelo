using Newtonsoft.Json;
using Testing1.Models;
using Zovelo.Models;

namespace Zovelo.Services
{
    public class ShoppingCartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string CartSessionKey = "Cart";

        public ShoppingCartService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public List<CartItem> GetCartItems()
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            if (session == null) return new List<CartItem>();

            var cartJson = session.GetString(CartSessionKey);
            if (string.IsNullOrEmpty(cartJson))
            {
                return new List<CartItem>();
            }
            return JsonConvert.DeserializeObject<List<CartItem>>(cartJson) ?? new List<CartItem>();
        }

        public void AddToCart(Product product, int quantity)
        {
            if (product == null || string.IsNullOrEmpty(product.ImageUrls))
            {
                throw new ArgumentNullException(nameof(product), "Product or ImageUrls cannot be null");
            }

            var cartItems = GetCartItems();
            var cartItem = cartItems.FirstOrDefault(i => i.ProductId == product.Id);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name ?? "Unknown Product",
                    Price = product.Price,
                    ImageUrl = product.ImageUrls.Split(',')[0],
                    Quantity = quantity
                });
            }

            SaveCartItems(cartItems);
        }

        public void RemoveFromCart(int productId)
        {
            var cartItems = GetCartItems();
            var cartItem = cartItems.FirstOrDefault(i => i.ProductId == productId);

            if (cartItem != null)
            {
                cartItems.Remove(cartItem);
                SaveCartItems(cartItems);
            }
        }

        public void ClearAllItems()
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            session?.Remove(CartSessionKey);
        }

        public void SaveCartItems(List<CartItem> cartItems)
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            if (session == null) return;

            var cartJson = JsonConvert.SerializeObject(cartItems);
            session.SetString(CartSessionKey, cartJson);
        }

        public decimal GetTotalPrice()
        {
            var cartItems = GetCartItems();
            return cartItems.Sum(i => i.Price * i.Quantity);
        }

        public int GetTotalItems()
        {
            var cartItems = GetCartItems();
            return cartItems.Sum(i => i.Quantity);
        }
    }
}
