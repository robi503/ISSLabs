using LibraryApp.Data;
using LibraryApp.Model;

namespace LibraryApp.Repositories
{
    public class BookRepository(LibraryContext context)
    {
        private readonly LibraryContext context = context;

        public IEnumerable<Book> GetAll()
        {
            return [.. context.Books];
        }

        public IEnumerable<Book> GetAvailableBooks()
        {
            return [.. context.Books.Where(b => !b.Rented)];
        }

        public void Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public void UpdateTitle(int id, string newTitle)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                book.Title = newTitle;
                context.SaveChanges();
            }
        }

        public void UpdateAuthor(int id, string newAuthor)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                book.Author = newAuthor;
                context.SaveChanges();
            }
        }

        public void UpdateGenre(int id, string newGenre)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                book.Genre = newGenre;
                context.SaveChanges();
            }
        }

        public void UpdateRented(int id, bool newRented)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                book.Rented = newRented;
                context.SaveChanges();
            }
        }
    }
}