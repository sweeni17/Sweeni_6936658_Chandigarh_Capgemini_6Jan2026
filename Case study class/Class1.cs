using System;
using System.Collections.Generic;

namespace ConsoleAppCGC
{
    enum BookStatus
    {
        Available,
        Sold
    }

    struct AuthorInfo
    {
        public string Name;
        public string Country;

        public AuthorInfo(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }

    interface ISellable
    {
        void SellBook();
    }

    class StoreItem
    {
        protected int price;

        public void ShowPrice()
        {
            Console.WriteLine("Price : " + price);
        }
    }

    class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }

    sealed class Books : StoreItem, ISellable
    {
        private string bookName;
        private AuthorInfo author;
        private BookStatus status;

        public Books(int price, AuthorInfo author, string bookName)
        {
            if (price <= 0)
                throw new InvalidPriceException("Price must be greater than zero");

            this.price = price;
            this.author = author;
            this.bookName = bookName;
            status = BookStatus.Available;
        }

        public void SellBook()
        {
            if (status == BookStatus.Available)
            {
                status = BookStatus.Sold;
                Console.WriteLine("Book Sold : " + bookName);
            }
            else
            {
                Console.WriteLine("Book already sold : " + bookName);
            }
        }

        public void ChangePrice(int newPrice)
        {
            try
            {
                if (newPrice <= 0)
                    throw new InvalidPriceException("Invalid price entered");

                price = newPrice;
                Console.WriteLine("Price updated successfully");
            }
            catch (InvalidPriceException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public void DisplayBook()
        {
            Console.WriteLine("Book Name : " + bookName);
            Console.WriteLine("Author    : " + author.Name);
            Console.WriteLine("Country   : " + author.Country);
            ShowPrice();
            Console.WriteLine("Status    : " + status);
            Console.WriteLine("----------------------------------");
        }
    }

    class StoreManager<T> where T : ISellable
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void SellItem(int index)
        {
            items[index].SellBook();
        }
    }
}
