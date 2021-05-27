using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> CartItems { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var cartItem in CartItems)
                    totalPrice += cartItem.Price * cartItem.Quantity;
                return totalPrice;
            }
        }
    }
}
