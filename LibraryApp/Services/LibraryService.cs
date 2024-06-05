using LibraryApp.Model;
using LibraryApp.Repositories;

namespace LibraryApp.Services
{
    public class LibraryService(BookRepository bookRepository, BorrowmentRepository borrowmentRepository)
    {
        private readonly BookRepository bookRepository = bookRepository;
        private readonly BorrowmentRepository borrowmentRepository = borrowmentRepository;

        public List<BorrowmentWithTitle> GetBorrowmentsByUser(string username)
        {
            return borrowmentRepository.FindByCustomerUsername(username);
        }

        public void AddBorrowment(Borrowment borrowment)
        {
            borrowmentRepository.Add(borrowment);
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepository.GetAll();
        }

        public IEnumerable<Book> GetAvailableBooks()
        {
            return bookRepository.GetAvailableBooks();
        }

        public void AddBook(Book book)
        {
            bookRepository.Add(book);
        }

        public void DeleteBook(int id)
        {
            bookRepository.Delete(id);
        }

        public void UpdateBook(int id, string updateType, string updateValue)
        {
            switch (updateType)
            {
                case "Title":
                    bookRepository.UpdateTitle(id, updateValue);
                    break;
                case "Author":
                    bookRepository.UpdateAuthor(id, updateValue);
                    break;
                case "Genre":
                    bookRepository.UpdateGenre(id, updateValue);
                    break;
                case "Rented":
                    bookRepository.UpdateRented(id, Convert.ToBoolean(updateValue));
                    break;
                default:
                    throw new ArgumentException("Invalid update type");
            }
        }
    }
}
