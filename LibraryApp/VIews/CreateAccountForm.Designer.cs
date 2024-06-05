namespace LibraryApp.VIews
{
    partial class CreateAccountForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            NameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            TelephoneTextBox = new TextBox();
            AddressTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            CreateAccountButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 70);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 283);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Telephone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 183);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 183);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 283);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 5;
            label6.Text = "Confirm password";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(31, 119);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(352, 27);
            NameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(591, 229);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(352, 27);
            PasswordTextBox.TabIndex = 7;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(591, 119);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(352, 27);
            UsernameTextBox.TabIndex = 8;
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.Location = new Point(31, 326);
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(352, 27);
            TelephoneTextBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(31, 229);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(352, 27);
            AddressTextBox.TabIndex = 10;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(591, 326);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(352, 27);
            ConfirmPasswordTextBox.TabIndex = 11;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.BackColor = SystemColors.Desktop;
            CreateAccountButton.ForeColor = SystemColors.Control;
            CreateAccountButton.Location = new Point(324, 459);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(342, 29);
            CreateAccountButton.TabIndex = 12;
            CreateAccountButton.Text = "Create account";
            CreateAccountButton.UseVisualStyleBackColor = false;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 596);
            Controls.Add(CreateAccountButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(TelephoneTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox NameTextBox;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private TextBox TelephoneTextBox;
        private TextBox AddressTextBox;
        private TextBox ConfirmPasswordTextBox;
        private Button CreateAccountButton;
    }
}