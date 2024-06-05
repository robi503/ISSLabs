using LibraryApp.Controllers;

namespace LibraryApp.VIews
{
    public partial class CreateAccountForm : Form
    {
        private readonly CreateAccountController controller;
        public CreateAccountForm(CreateAccountController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            controller.HandleCreateAccountButtonClick(NameTextBox, AddressTextBox, UsernameTextBox,
                TelephoneTextBox, PasswordTextBox, ConfirmPasswordTextBox);
        }
    }
}
