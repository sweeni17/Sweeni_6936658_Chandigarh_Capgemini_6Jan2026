using System;
using System.Collections.Generic;
using System.Linq;

public struct Product
{
    public string ProductID;
    public int TotalSales;

    public Product(string id, int sales)
    {
        ProductID = id;
        TotalSales = sales;
    }
}

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> productMap = new Dictionary<string, int>();

        Console.WriteLine("Enter product records (Press Enter on empty line to stop):");

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            string[] parts = input.Split('-');

            string productID = parts[0];
            int sales = int.Parse(parts[1]);

            // Keep highest sales amount for same product
            if (productMap.ContainsKey(productID))
            {
                productMap[productID] = Math.Max(productMap[productID], sales);
            }
            else
            {
                productMap[productID] = sales;
            }
        }

        // Convert to list of Product struct
        List<Product> products = productMap
            .Select(p => new Product(p.Key, p.Value))
            .OrderByDescending(p => p.TotalSales)
            .ToList();

        // Print output
        foreach (var product in products)
        {
            Console.WriteLine(product.ProductID + "-" + product.TotalSales);
        }
    }
}
