using System;

namespace ConsoleAppCGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AuthorInfo author1 = new AuthorInfo("Siddhi", "India");
                AuthorInfo author2 = new AuthorInfo("Manyata", "India");

                Books book1 = new Books(600, author1, "Sinner");
                Books book2 = new Books(650, author2, "O Re Piya");

                StoreManager<Books> store = new StoreManager<Books>();

                store.AddItem(book1);
                store.AddItem(book2);

                book1.DisplayBook();
                store.SellItem(0);

                book2.DisplayBook();
                book2.ChangePrice(620);
                store.SellItem(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Error : " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
