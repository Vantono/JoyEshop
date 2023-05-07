using JoyCore.Interfaces;

namespace JoyCore.Models
{
    public class ShoppingCartItem : IEntity<int>
    {
        public int Id { get; set; }
        public Product Product { get; set; } = new Product();
        public int Amount { get; set; }
    }
}