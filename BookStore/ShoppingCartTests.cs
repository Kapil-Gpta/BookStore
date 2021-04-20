using System;
using System.Collections.Generic;
using Xunit;

namespace BookStore
{
    public class ShoppingCartTests
    {
        public class AddMemberToPolicyHandlerTests
        {

            [Fact]
            public  void BookStore_DeliveryFees_NotCharged()
            {
                // arrange
                var books = new List<Book>
                {
                    new Crime {Title = "Crime Thriller", Author = "Emily", Price = 10.0},
                    new Romance {Title = "Romance Story", Author = "Roland", Price = 10.00},
                    new Fantasy {Title = "Fantasy", Author = "SJ", Price = 5.50},
                };

                var shoppingCart = new ShoppingCart(books);

                // act
                shoppingCart.CalculateTotalPrice(.10,5);

                // assert
                Assert.Equal(25.00, Math.Round(shoppingCart.TotalPrice,2));
                Assert.Equal(27.50, Math.Round(shoppingCart.TotalPriceWithTax,2));
            }
            
            [Fact]
            public  void BookStore_DeliveryFees_Charged()
            {
                // arrange
                var books = new List<Book>
                {
                    new Crime {Title = "Crime Thriller", Author = "Emily", Price = 10.0},
                    new Romance {Title = "Romance Story", Author = "Roland", Price = 2.00},
                    new Fantasy {Title = "Fantasy", Author = "SJ", Price = 5.50},
                };

                var shoppingCart = new ShoppingCart(books);

                // act
                shoppingCart.CalculateTotalPrice(.10,5);

                // assert
                Assert.Equal(22.00, Math.Round(shoppingCart.TotalPrice,2));
                Assert.Equal(24.20, Math.Round(shoppingCart.TotalPriceWithTax,2));
            }
        }
    }
}

    