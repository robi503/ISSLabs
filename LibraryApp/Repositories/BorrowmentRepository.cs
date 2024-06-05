using LibraryApp.Data;
using LibraryApp.Model;

namespace LibraryApp.Repositories
{
    public class BorrowmentRepository(LibraryContext context)
    {
        private readonly LibraryContext _context = context;

        public void Add(Borrowment borrowment)
        {
            _context.Borrowments.Add(borrowment);
            _context.SaveChanges();
        }

        public List<BorrowmentWithTitle> FindByCustomerUsername(string customerUsername)
        {
            var borrowmentsWithTitles = (from borrowment in _context.Borrowments
                                         join book in _context.Books on borrowment.BookId equals book.Id
                                         where borrowment.CustomerUsername == customerUsername
                                         select new BorrowmentWithTitle
                                         (
                                             borrowment.CustomerUsername,
                                             borrowment.BookId,
                                             book.Title,
                                             borrowment.BorrowDate,
                                             borrowment.ReturnDate
                                        )).ToList();

            return borrowmentsWithTitles;
        }
    }
}
