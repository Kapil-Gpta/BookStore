using System;
using System.Collections.Generic;

namespace BookStore
{
    internal static class Program
    {
        private const double Tax = .10; 
        private const double DeliveryFees = 5.95;
        public static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Crime {Title = "Unsolved Murders", Author = "Emily G", Price = 10.99},
                new Romance {Title = "A Little Love Story", Author = "Roland Merullo", Price = 2.40},
                new Fantasy {Title = "Heresy", Author = "SJ Parris", Price = 6.80},
                new Crime {Title = "Jack the Ripper", Author = "Philip Sudgen", Price = 16.0},
                new Fantasy {Title = "The Tolkein Years", Author = "Greg H", Price = 22.90},
            };

            var shoppingCart = new ShoppingCart(books);

            shoppingCart.CalculateTotalPrice(Tax, DeliveryFees);

            Console.WriteLine("Total price without Tax is {0:#.##}", shoppingCart.TotalPrice);
            Console.WriteLine("Total price with Tax is {0:#.##}",shoppingCart.TotalPriceWithTax);
            Console.ReadLine();
        }
    }
}