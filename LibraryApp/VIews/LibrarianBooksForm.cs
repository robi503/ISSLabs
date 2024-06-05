using LibraryApp.Controllers;

namespace LibraryApp.VIews
{
    public partial class LibrarianBooksForm : Form
    {
        private readonly LibrarianBooksController controller;
        public LibrarianBooksForm(LibrarianBooksController controller)
        {
            this.controller = controller;
            InitializeComponent();
            controller.InitDataGrid(booksGridView);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            controller.HandleAddButtonClick(titleTextBox, authorTextBox, genreTextBox);
        }
    }
}
