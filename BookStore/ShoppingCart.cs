using System.Collections.Generic;

namespace BookStore
{
    public class ShoppingCart
    {
        private readonly List<Book> _books;
        public double TotalPrice;
        public double TotalPriceWithTax;

        public ShoppingCart(List<Book> books)
        {
            _books = books;
        }

        public void CalculateTotalPrice(double taxPercent,double deliveryFee)
        {
            foreach (var book in _books)
            {
                TotalPrice += book.GetPrice();
            }

            TotalPrice= TotalPrice <20?TotalPrice +deliveryFee : TotalPrice  ;
            TotalPriceWithTax = TotalPrice * (1 + taxPercent);
        }
    }
}