using System;
using System.Collections.Generic;
using System.Linq;

public class ShoppingCartItem
{
    public string ProductName { get; set; }
    public double Price { get; set; }
}

public class OnlineStore
{
    public static double CalculateValue(List<ShoppingCartItem> products, double discountPercentage)
    {
        double totalPrice = products.Sum(item => item.Price);
        double discountAmount = totalPrice * (discountPercentage / 100);
        double discountedPrice = totalPrice - discountAmount;
        return discountedPrice;
    }
}

class Program
{
    static void Main()
    {
        List<ShoppingCartItem> products = new List<ShoppingCartItem>
        {
            new ShoppingCartItem { ProductName = "Product 1", Price = 10.00 },
            new ShoppingCartItem { ProductName = "Product 2", Price = 20.00 },
            new ShoppingCartItem { ProductName = "Product 3", Price = 30.00 }
        };

        double discountPercentage = 10.0; // 10% discount

        double discountedTotal = OnlineStore.CalculateValue(products, discountPercentage);
        Console.WriteLine($"Discounted Total: {discountedTotal:C}");
    }
}
