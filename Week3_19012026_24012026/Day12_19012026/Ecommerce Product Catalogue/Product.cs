using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce_Product_Catalogue
{
    internal class Product
    {
        
            public int ProductId;
            public string ProductName;
            protected double Price;
            protected int Stock;

            public Product()
            {
                Console.Write("Enter Product ID: ");
                ProductId = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                ProductName = Console.ReadLine();
                Console.Write("Enter Price: ");
                Price = double.Parse(Console.ReadLine());
                Console.Write("Enter Stock: ");
                Stock = int.Parse(Console.ReadLine());
            }

            public virtual void DisplayProduct()
            {
                Console.WriteLine("\nID    : " + ProductId);
                Console.WriteLine("Name  : " + ProductName);
                Console.WriteLine("Price : ₹" + Price);
                Console.WriteLine("Stock : " + Stock);
            }

            public bool IsAvailable()
            {
                return Stock > 0;
            }

            public void ReduceStock(int qty)
            {
                if (Stock >= qty)
                    Stock -= qty;
                else
                    Console.WriteLine("Insufficient stock!");
            }

            public double GetPrice()
            {
                return Price;
       }

    }

    class Electronics : Product
    {
        public int Warranty;

        public Electronics()
        {
            Console.Write("Enter Warranty (years): ");
            Warranty = int.Parse(Console.ReadLine());
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine("Warranty : " + Warranty + " years");
            Console.WriteLine("Category : Electronics");
        }
    }

    class Clothing : Product
    {
        public string Size;

        public Clothing()
        {
            Console.Write("Enter Size (S/M/L): ");
            Size = Console.ReadLine();
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine("Size     : " + Size);
            Console.WriteLine("Category : Clothing");
        }
    }

    class Books : Product
    {
        public string Author;

        public Books()
        {
            Console.Write("Enter Author Name: ");
            Author = Console.ReadLine();
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine("Author   : " + Author);
            Console.WriteLine("Category : Books");
        }
    }

    class Customer
    {
        public int CustomerId;
        public string Name;

        public Customer()
        {
            Console.Write("Enter Customer ID: ");
            CustomerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            Name = Console.ReadLine();
        }
    }

    class Cart
    {
        public List<Product> products = new List<Product>();

        public void AddToCart(Product p)
        {
            if (p.IsAvailable())
            {
                products.Add(p);
                p.ReduceStock(1);
                Console.WriteLine("Product added to cart.");
            }
            else
                Console.WriteLine("Product out of stock!");
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Product p in products)
                total += p.GetPrice();
            return total;
        }
    }

    class Order
    {
        public Cart cart;
        public double TotalAmount;

        public Order(Cart c)
        {
            cart = c;
            TotalAmount = cart.CalculateTotal();
        }

        public void DisplayOrder()
        {
            Console.WriteLine("\n----- Order Summary -----");
            Console.WriteLine("Total Items : " + cart.products.Count);
            Console.WriteLine("Total Amount: ₹" + TotalAmount);
        }
    }


}
