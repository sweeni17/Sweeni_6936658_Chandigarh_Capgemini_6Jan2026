using LibraryApp.Models;

namespace LibraryApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>()
{
    new Book{ Id = 1, Title = "The Thief Who Stole the Sun", Author = "Sweeni" },
    new Book{ Id = 2, Title = "Sweet n Sour", Author = "Siddhi Kadam" },
    new Book{ Id = 3, Title = "Incomprehensible Love", Author = "Manyata Sharma" }
};

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
    }
}