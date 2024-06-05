namespace LibraryApp.VIews
{
    partial class LibrarianHomeForm
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
            UsersButton = new Button();
            booksButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            RegisterLibrarianButton = new Button();
            LogOutButton = new Button();
            SuspendLayout();
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(113, 106);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(119, 60);
            UsersButton.TabIndex = 0;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // booksButton
            // 
            booksButton.Location = new Point(113, 303);
            booksButton.Name = "booksButton";
            booksButton.Size = new Size(119, 60);
            booksButton.TabIndex = 1;
            booksButton.Text = "Books";
            booksButton.UseVisualStyleBackColor = true;
            booksButton.Click += BooksButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 106);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 184);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 263);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(577, 103);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(257, 27);
            NameTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(577, 260);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(257, 27);
            PasswordTextBox.TabIndex = 6;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(577, 181);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(257, 27);
            UsernameTextBox.TabIndex = 7;
            // 
            // RegisterLibrarianButton
            // 
            RegisterLibrarianButton.Location = new Point(465, 334);
            RegisterLibrarianButton.Name = "RegisterLibrarianButton";
            RegisterLibrarianButton.Size = new Size(369, 29);
            RegisterLibrarianButton.TabIndex = 8;
            RegisterLibrarianButton.Text = "Register new librarian";
            RegisterLibrarianButton.UseVisualStyleBackColor = true;
            RegisterLibrarianButton.Click += RegisterLibrarianButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = SystemColors.Desktop;
            LogOutButton.ForeColor = SystemColors.Control;
            LogOutButton.Location = new Point(113, 419);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(119, 29);
            LogOutButton.TabIndex = 9;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // LibrarianHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 480);
            Controls.Add(LogOutButton);
            Controls.Add(RegisterLibrarianButton);
            Controls.Add(UsernameTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(booksButton);
            Controls.Add(UsersButton);
            Name = "LibrarianHomeForm";
            Text = "AdminHomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UsersButton;
        private Button booksButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTextBox;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Button RegisterLibrarianButton;
        private Button LogOutButton;
    }
}