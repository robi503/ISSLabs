using LibraryApp.Controllers;
namespace LibraryApp.VIews
{
    public partial class LibrarianHomeForm : Form
    {
        private readonly LibrarianHomeController adminHomeController;
        public LibrarianHomeForm(LibrarianHomeController adminHomeController)
        {
            this.adminHomeController = adminHomeController;
            InitializeComponent();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            adminHomeController.HandleBooksButtonClick();
        }

        private void RegisterLibrarianButton_Click(object sender, EventArgs e)
        {
            adminHomeController.HandleRegisterLibrarianButtonClick(NameTextBox, UsernameTextBox, PasswordTextBox);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            adminHomeController.HandleUsersButtonClick();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
