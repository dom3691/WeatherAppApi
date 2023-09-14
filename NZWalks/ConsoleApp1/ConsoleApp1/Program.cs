using System;
using System.Collections.Generic;
namespace ConsoleApp1.Programs
{

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class ShoppingCart
    {


        public static decimal CalculateValue(List<Product> products, decimal discountPercentage)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Discount percentage must be between 0 and 100.", nameof(discountPercentage));
            }

            decimal totalValue = 0;

            // Calculate the total value of the cart
            foreach (var product in products)
            {
                totalValue += product.Price;
            }

            // Apply the discount
            decimal discountAmount = (totalValue * discountPercentage) / 100;
            decimal finalValue = totalValue - discountAmount;

            return finalValue;
        }
    }

    // Example usage:
    // List<ShoppingCart.Product> products = new List<ShoppingCart.Product>
    // {
    //     new ShoppingCart.Product("Product 1", 25.99m),
    //     new ShoppingCart.Product("Product 2", 15.49m),
    //     new ShoppingCart.Product("Product 3", 10.00m)
    // };

    // decimal discountPercentage = 10.0m; // 10% discount
    // decimal cartValue = ShoppingCart.CalculateValue(products, discountPercentage);
    // Console.WriteLine($"Cart Value: {cartValue}");
}