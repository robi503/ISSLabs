using LibraryApp.Controllers;

namespace LibraryApp
{
    public partial class CustomerHomeForm : Form
    {
        private readonly CustomerHomeController customerHomeController;
        public CustomerHomeForm(CustomerHomeController mainFormController)
        {
            customerHomeController = mainFormController;
            InitializeComponent();
            customerHomeController.InitAvailableBooksGrid(booksGridView);
            customerHomeController.InitRentedBooksGrid(RentedBooksGridView);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            customerHomeController.HandleRentButtonClick(booksGridView);
        }
    }
}
