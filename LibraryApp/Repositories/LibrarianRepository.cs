using LibraryApp.Data;
using LibraryApp.Model;

namespace LibraryApp.Repositories
{
    public class LibrarianRepository(LibraryContext context)
    {
        private readonly LibraryContext _context = context;

        public Librarian? FindByUsername(string username)
        {
            return _context.Librarians.Find(username);
        }

        public void Add(Librarian librarian)
        {
            _context.Librarians.Add(librarian);
            _context.SaveChanges();
        }
    }
}
