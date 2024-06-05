using LibraryApp.Controllers;

namespace LibraryApp.VIews
{
    public partial class LibrarianCustomersForm : Form
    {
        private readonly LibrarianCustomerController _customerController;
        public LibrarianCustomersForm(LibrarianCustomerController librarianCustomerController)
        {
            _customerController = librarianCustomerController;
            InitializeComponent();
            _customerController.InitDataGrid(CustomerDataGridView);
        }
    }
}
