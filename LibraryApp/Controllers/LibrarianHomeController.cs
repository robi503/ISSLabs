using LibraryApp.Model;
using LibraryApp.Services;
using LibraryApp.VIews;


namespace LibraryApp.Controllers
{
    public class LibrarianHomeController
    {
        private readonly AccountsService _accountsService;
        private readonly LibraryService _libraryService;

        public LibrarianHomeController(AccountsService accountsService, LibraryService libraryService)
        {
            _accountsService = accountsService;
            _libraryService = libraryService;
            LibrarianHomeForm librarianHomeForm = new(this);
            librarianHomeForm.Show();
        }

        public void HandleBooksButtonClick() 
        {
            _ = new LibrarianBooksController(_libraryService);
        }

        public void HandleUsersButtonClick()
        {
            _ = new LibrarianCustomerController(_accountsService);
        }

        public void HandleRegisterLibrarianButtonClick(TextBox nameTextBox, TextBox usernameTextBox, TextBox passwordTextBox)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string name = nameTextBox.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if(_accountsService.GetLibrarian(username) != null)
            {
                MessageBox.Show("Username already taken.");
                return;
            }

            Librarian librarian = new(username, name, password);
            _accountsService.RegisterLibrarian(librarian);
            MessageBox.Show("Librarian registered successfully.");
        }
    }
}
