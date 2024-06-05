using LibraryApp.Controllers;

namespace LibraryApp.VIews
{
    public partial class LoginForm : Form
    {
        private readonly LoginController controller;
        public LoginForm(LoginController loginFormController)
        {
            controller = loginFormController;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            controller.HandleLoginButtonClick(UsernameTextbox, PasswordTextBox, AdminCheckBox);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            controller.HandleSignUpButtonClick();
        }
    }
}
