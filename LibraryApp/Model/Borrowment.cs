namespace LibraryApp.Model
{
    public class Borrowment
    {

        public int Id { get; set; }
        public string CustomerUsername { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set;}
        public DateTime ReturnDate { get; set; }

        public Borrowment(string customerUsername, int bookId)
        { 
            CustomerUsername = customerUsername;
            BookId = bookId;
            BorrowDate = DateTime.Now;
            ReturnDate = DateTime.Now.AddDays(14);
        }

        public Borrowment(string customerUsername, int bookId, DateTime borrowDate, DateTime returnDate)
        {
            CustomerUsername = customerUsername;
            BookId = bookId;
            BorrowDate=borrowDate;
            ReturnDate = returnDate;
        }
    }

    public class BorrowmentWithTitle(string customerUsername, int bookId, string title, DateTime borrowDate, DateTime returnDate) : Borrowment(customerUsername, bookId, borrowDate, returnDate)
    {
        public string BookTitle { get; set; } = title;
    }
}
