using LibraryApp.Model;
using LibraryApp.Services;
using LibraryApp.VIews;

namespace LibraryApp.Controllers
{
    public class CreateAccountController
    {
        private readonly AccountsService _accountsService;

        public CreateAccountController(AccountsService accountsService)
        {
            _accountsService = accountsService;
            CreateAccountForm createAccountForm = new(this);
            createAccountForm.Show();
        }

        public void HandleCreateAccountButtonClick(TextBox nameTextBox, TextBox addressTextBox, TextBox usernameTextBox,
            TextBox telephoneTextBox, TextBox passwordTextBox, TextBox confirmPasswordTextBox)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string username = usernameTextBox.Text;
            string telephone = telephoneTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(telephone) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if(_accountsService.GetCustomer(username) != null)
            {
                MessageBox.Show("Username already taken.");
                return;
            }

            if(password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            Customer customer = new(username, name, address, telephone, password);
            _accountsService.AddCustomer(customer);
            MessageBox.Show("Account created successfully.");
            return;
        }
    }
}
