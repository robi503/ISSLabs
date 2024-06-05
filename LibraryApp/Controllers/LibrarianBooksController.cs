using LibraryApp.Model;
using LibraryApp.Services;
using LibraryApp.VIews;
using System.ComponentModel;

namespace LibraryApp.Controllers
{
    public class LibrarianBooksController
    {
        private readonly LibraryService service;

        public LibrarianBooksController(LibraryService service)
        {
            this.service = service;
            LibrarianBooksForm adminBooksForm = new(this);
            adminBooksForm.Show();
        }
        public void InitDataGrid(DataGridView dataGridView)
        {
            var books = new BindingList<Book>((IList<Book>)service.GetAllBooks());
            dataGridView.DataSource = books;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[0].Visible = false;
            }

            // Add button column
            DataGridViewButtonColumn buttonColumn = new()
            {
                HeaderText = "",
                Name = "DeleteButton",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView.Columns.Add(buttonColumn);

            // Set the AutoSizeColumnsMode to Fill
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add event handler for button clicks
            dataGridView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
            dataGridView.CellEndEdit += new DataGridViewCellEventHandler(DataGridView_CellEndEdit);
        }

        private void DataGridView_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Ensure sender is not null and is of type DataGridView
            if (sender is DataGridView dataGridView)
            {
                // Ensure the click is on a valid row and on the button column
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView.Columns["DeleteButton"].Index)
                {
                    // Get the ID value from the corresponding cell in the same row
                    object idValue = dataGridView.Rows[e.RowIndex].Cells["Id"].Value;

                    // Check if the ID value is not null and is of the expected type
                    if (idValue != null && idValue is int id)
                        try
                        {
                            // Attempt to delete the book using the BookService
                            service.DeleteBook(id);
                        }
                        catch (Exception ex)
                        {
                            // Display the error message if an exception occurs
                            MessageBox.Show($"Error occurred while deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        // Handle case where ID value is null or not of expected type
                        MessageBox.Show("Unable to retrieve the ID of the book.");
                    }
                }
            }
        }

        public void DataGridView_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            // Ensure sender is not null and is of type DataGridView
            if (sender is DataGridView dataGridView)
            {
                // Check if editing was done in a valid row and column
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the edited cell
                    DataGridViewCell editedCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex]; 
                    var editedColumnName = dataGridView.Columns[e.ColumnIndex].Name;
                    object idValue = dataGridView.Rows[e.RowIndex].Cells["Id"].Value;
                    var editedValue = editedCell.Value;
                    if(editedValue != null)
                    {
                        service.UpdateBook((int)idValue, editedColumnName, editedValue.ToString());
                    }
                }
            }
        }


        public void HandleAddButtonClick(TextBox titleTextBox, TextBox authorTextBox, TextBox genreTextBox)
        {
            // Get the values entered by the user in the text boxes
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;
            string genre = genreTextBox.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(genre))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the function if any field is empty
            }

            // Create a new Book object with the entered values
            Book newBook = new (title, author, genre, false);

            try
            {
                service.AddBook(newBook);
                MessageBox.Show("Book added successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error occurred while adding book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                titleTextBox.Clear();
                authorTextBox.Clear();
                genreTextBox.Clear();
            }
        }
    }
}
