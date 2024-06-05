namespace LibraryApp.VIews
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            UsernameTextbox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SignUpButton = new Button();
            AdminCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 95);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 234);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(211, 161);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(258, 27);
            UsernameTextbox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(211, 290);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(258, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.Desktop;
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(211, 413);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.Desktop;
            SignUpButton.ForeColor = SystemColors.Control;
            SignUpButton.Location = new Point(375, 413);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(94, 29);
            SignUpButton.TabIndex = 5;
            SignUpButton.Text = "Sign up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Location = new Point(96, 418);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.RightToLeft = RightToLeft.Yes;
            AdminCheckBox.Size = new Size(75, 24);
            AdminCheckBox.TabIndex = 7;
            AdminCheckBox.Text = "Admin";
            AdminCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 606);
            Controls.Add(AdminCheckBox);
            Controls.Add(SignUpButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button SignUpButton;
        private CheckBox AdminCheckBox;
    }
}