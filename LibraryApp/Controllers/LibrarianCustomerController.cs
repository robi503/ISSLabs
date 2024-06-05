using LibraryApp.Model;
using System.ComponentModel;
using LibraryApp.Services;
using LibraryApp.VIews;

namespace LibraryApp.Controllers
{
    public class LibrarianCustomerController
    {
        private readonly AccountsService _accountsService;

        public LibrarianCustomerController(AccountsService accountsService)
        {
            _accountsService = accountsService;
            LibrarianCustomersForm customersForm = new(this);
            customersForm.Show();
        }

        public void InitDataGrid(DataGridView dataGridView)
        {
            var customers = new BindingList<Customer>((IList<Customer>)_accountsService.GetAllCustomers());
            dataGridView.DataSource = customers;

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[0].ReadOnly = true;
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

            dataGridView.Dock = DockStyle.Fill;

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
                    object idValue = dataGridView.Rows[e.RowIndex].Cells["Username"].Value;

                    // Check if the ID value is not null and is of the expected type
                    if (idValue != null)
                        try
                        {
                            // Attempt to delete the book using the BookService
                            _accountsService.DeleteCustomer((string)idValue);
                        }
                        catch (Exception ex)
                        {
                            // Display the error message if an exception occurs
                            MessageBox.Show($"Error occurred while deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        // Handle case where ID value is null or not of expected type
                        MessageBox.Show("Unable to retrieve the username of the customer.");
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
                    object idValue = dataGridView.Rows[e.RowIndex].Cells["Username"].Value;

                    // Check if the ID value is not null and is of the expected type
                    if (idValue != null)
                        try
                        {
                            Customer? customer = _accountsService.GetCustomer((string)idValue);
                            if (customer == null)
                            {
                                MessageBox.Show("Customer with this username does not exist.");
                                return;
                            }
                            _accountsService.UpdateCustomer(customer);
                        }
                        catch (Exception ex)
                        {
                            // Display the error message if an exception occurs
                            MessageBox.Show($"Error occurred while deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        // Handle case where ID value is null or not of expected type
                        MessageBox.Show("Unable to retrieve the username of the customer.");
                    }
                }
            }
        }
    }

}
