using System;
using System.Data;

public class ShoppingCartItems
{
    public string ProductName { get; set; }
    public double Price { get; set; }
}

public class OnlineStore
{
    public static double CalculateValue(List<ShoppingCartItems> items, double discountPercentage)
    {
        double totalPrice = items.Sum(x => x.Price);
        double discountAmount = totalPrice * (discountPercentage / 100);
        double discountedPrice = totalPrice - discountAmount;
        return discountAmount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<ShoppingCartItems> items = new List<ShoppingCartItems>
        {
            new ShoppingCartItems
            {
                ProductName = "Milk ",
                Price = 50,
            },

               new ShoppingCartItems
            {
                ProductName = "Bread",
                Price = 90,
            },
                  new ShoppingCartItems
            {
                ProductName = "Yamarita",
                Price = 20,
            }
        };

        double discountPercentage = 10.0; // 10% discount 

        double discountedTotal = OnlineStore.CalculateValue(items, discountPercentage);
        Console.WriteLine($"Discounted Total: {discountedTotal: C}");
    }
}
