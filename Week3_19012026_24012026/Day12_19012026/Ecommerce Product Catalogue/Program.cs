namespace Ecommerce_Product_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new List<Product>();
            Cart cart = new Cart();
            int choice;

            do
            {
                Console.WriteLine("\n---- E-Commerce Product Catalog ----");
                Console.WriteLine("1. Add Electronics");
                Console.WriteLine("2. Add Clothing");
                Console.WriteLine("3. Add Book");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("5. Add Product to Cart");
                Console.WriteLine("6. Place Order");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: catalog.Add(new Electronics()); break;
                    case 2: catalog.Add(new Clothing()); break;
                    case 3: catalog.Add(new Books()); break;

                    case 4:
                        foreach (Product p in catalog)
                            p.DisplayProduct();
                        break;

                    case 5:
                        if (catalog.Count > 0)
                            cart.AddToCart(catalog[0]);
                        else
                            Console.WriteLine("No products available!");
                        break;

                    case 6:
                        Order o = new Order(cart);
                        o.DisplayOrder();
                        break;
                }

            } while (choice != 7);
        }
    }
}
