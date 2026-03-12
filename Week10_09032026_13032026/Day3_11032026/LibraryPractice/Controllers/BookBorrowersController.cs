using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryPractice.Models;

namespace LibraryPractice.Controllers
{
    public class BookBorrowersController : Controller
    {
        private readonly MvcContext _context;

        public BookBorrowersController(MvcContext context)
        {
            _context = context;
        }

        // GET: BookBorrowers
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.BookBorrowers.Include(b => b.Book).Include(b => b.Borrower);
            return View(await mvcContext.ToListAsync());
        }

        // GET: BookBorrowers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers
                .Include(b => b.Book)
                .Include(b => b.Borrower)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookBorrower == null)
            {
                return NotFound();
            }

            return View(bookBorrower);
        }

        // GET: BookBorrowers/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId");
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "BorrowerId");
            return View();
        }

        // POST: BookBorrowers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,BorrowerId,BorrowDate,ReturnDate")] BookBorrower bookBorrower)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookBorrower);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "BorrowerId", bookBorrower.BorrowerId);
            return View(bookBorrower);
        }

        // GET: BookBorrowers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers.FindAsync(id);
            if (bookBorrower == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "BorrowerId", bookBorrower.BorrowerId);
            return View(bookBorrower);
        }

        // POST: BookBorrowers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,BorrowerId,BorrowDate,ReturnDate")] BookBorrower bookBorrower)
        {
            if (id != bookBorrower.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookBorrower);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookBorrowerExists(bookBorrower.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "BorrowerId", bookBorrower.BorrowerId);
            return View(bookBorrower);
        }

        // GET: BookBorrowers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers
                .Include(b => b.Book)
                .Include(b => b.Borrower)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookBorrower == null)
            {
                return NotFound();
            }

            return View(bookBorrower);
        }

        // POST: BookBorrowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookBorrower = await _context.BookBorrowers.FindAsync(id);
            if (bookBorrower != null)
            {
                _context.BookBorrowers.Remove(bookBorrower);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookBorrowerExists(int id)
        {
            return _context.BookBorrowers.Any(e => e.Id == id);
        }
    }
}
