using LibraryApp.Data;
using System.Configuration;
using LibraryApp.Model;
using LibraryApp.Repositories;
using LibraryApp.Services;
using LibraryApp.VIews;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers
{
    public class LoginController(AccountsService service)
    {
        private readonly AccountsService accountsService = service;

        private void LibrarianLogin(string username, string password)
        {
            Librarian? librarian = accountsService.GetLibrarian(username);

            if (librarian == null)
            {
                MessageBox.Show("Incorrect username.");
                return;
            }

            if (librarian.Password != password)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            var dbContext = new LibraryContext(optionsBuilder.Options);
            BookRepository bookRepository = new(dbContext);
            BorrowmentRepository borrowmentRepository = new(dbContext);
            LibraryService libraryService = new(bookRepository, borrowmentRepository);
            _ = new LibrarianHomeController(accountsService, libraryService);
        }

        private void CustomerLogin(string username, string password)
        {
            Customer? customer = accountsService.GetCustomer(username);

            if (customer == null)
            {
                MessageBox.Show("Incorrect username.");
                return;
            }
            if (customer.Password != password)
            {
                MessageBox.Show("Incorrect password.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            var dbContext = new LibraryContext(optionsBuilder.Options);
            BookRepository bookRepository = new(dbContext);
            BorrowmentRepository borrowmentRepository = new(dbContext);
            LibraryService libraryService = new(bookRepository, borrowmentRepository);
            _ = new CustomerHomeController(libraryService, username);
        }

        public void HandleSignUpButtonClick()
        {
            _ = new CreateAccountController(accountsService);
        }

        public void HandleLoginButtonClick(TextBox usernameTextBox, TextBox passwordTextBox, CheckBox adminCheckBox)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; 
            }

            if(adminCheckBox.Checked)
            {
                LibrarianLogin(username, password);
            }
            else
            {
                CustomerLogin(username, password);
            }
        }
    }
}
