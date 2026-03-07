using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title;
    public int Price;
    public int Stock;

    public Book(string title, int price, int stock)
    {
        Title = title; 
        Price = price;
        Stock = stock;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book("Kahani", 250, 5),
            new Book("Siyahee", 300, 4),
            new Book("Arirang", 300, 5),
            new Book("Yellow", 270, 2)
        };

        int TargetValue = 500;
        var CheapBooks =
            from book in books
            where book.Price < TargetValue
            select book;
        Console.WriteLine("Books Cheaper than Target Price: " + CheapBooks);

        foreach(var b in CheapBooks)
        {
            Console.WriteLine(b.Title + " - " + b.Price);
        }

        books =
            (from b in books
             select new Book(
                 b.Title,
                 (int)(b.Price + (b.Price * 0.10)),
                 b.Stock)).ToList();
        Console.WriteLine("Price after 10% increase: ");
            foreach (var b in books)
        {
            Console.WriteLine(b.Title + " - " + b.Price);
        }
        Console.WriteLine("----------------------------");

        books = 
            (from b in books
             where b.Stock > 0
             select b).ToList();
        Console.WriteLine("Available Books: ");
        foreach (var b in books)
        {
            Console.WriteLine(b.Title + " - " + b.Price);
        }
    }

    
}