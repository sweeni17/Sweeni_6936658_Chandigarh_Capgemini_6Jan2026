using System;
using System.Collections.Generic;

namespace LibraryPractice.Models;

public partial class BookBorrower
{
    public int Id { get; set; }

    public int? BookId { get; set; }

    public int? BorrowerId { get; set; }

    public DateOnly? BorrowDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Borrower? Borrower { get; set; }
}
