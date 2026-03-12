using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCdemoBook.Models;

namespace MVCDemoBook.Controllers
{
    public class BookController1 : Controller
    {
        private readonly BookDbContext _context;

        public BookController1(BookDbContext context)
        {
            _context = context;
        }

        // GET: BookController
        public IActionResult Index()
        {
            var books = _context.books.ToList();
            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel book)
        {
            try
            {
                _context.books.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
