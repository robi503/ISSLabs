using LibraryApp.Model;
using System.ComponentModel;
using LibraryApp.Services;

namespace LibraryApp.Controllers
{
    public class CustomerHomeController
    {
        private readonly LibraryService bookService;

        private readonly string username;

        public CustomerHomeController(LibraryService bookService, string username)
        {
            this.bookService = bookService;
            this.username = username;
            CustomerHomeForm customerHomeForm = new(this)
            {
                Text = "Welcome, " + username + '!'
            };
            customerHomeForm.Show();
        }

        public void InitAvailableBooksGrid(DataGridView dataGridView)
        {
            var books = new BindingList<Book>((IList<Book>)bookService.GetAvailableBooks());
            dataGridView.DataSource = books;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.ReadOnly = true;
            }

            // Set the first column to not be visible
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[0].Visible = false;
            }

            if (dataGridView.Columns.Contains("Rented"))
            {
                dataGridView.Columns["Rented"].Visible = false;
            }

            // Set the AutoSizeColumnsMode to Fill
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void InitRentedBooksGrid(DataGridView dataGridView)
        {
            // Get available borrowments with titles
            var borrowmentsWithTitles = new BindingList<BorrowmentWithTitle>(bookService.GetBorrowmentsByUser(username));

            // Set the data source
            dataGridView.DataSource = borrowmentsWithTitles;

            // Make all columns read-only
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.ReadOnly = true;
            }

            if (dataGridView.Columns.Contains("Id"))
            {
                dataGridView.Columns["Id"].Visible = false;
            }
            if (dataGridView.Columns.Contains("CustomerUsername"))
            {
                dataGridView.Columns["CustomerUsername"].Visible = false;
            }
            if (dataGridView.Columns.Contains("BookId"))
            {
                dataGridView.Columns["BookId"].Visible = false;
            }

            // Set the AutoSizeColumnsMode to Fill
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void HandleRentButtonClick(DataGridView dataGridView)
        {
            foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
            {
                int id = (int)selectedRow.Cells["Id"].Value;
                bookService.UpdateBook(id, "Rented", "true");
                bookService.AddBorrowment(new Borrowment(username, id));
            }
        }
    }
}
