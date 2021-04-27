using Sklep.Models;

namespace Sklep.Infrastructure
{
    public class CartItem
    {
        public Film Film { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}