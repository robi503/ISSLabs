namespace LibraryApp.VIews
{
    partial class LibrarianBooksForm
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
            booksGridView = new DataGridView();
            addBookButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            genreTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)booksGridView).BeginInit();
            SuspendLayout();
            // 
            // booksGridView
            // 
            booksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksGridView.Location = new Point(30, 41);
            booksGridView.Name = "booksGridView";
            booksGridView.RowHeadersWidth = 51;
            booksGridView.Size = new Size(805, 397);
            booksGridView.TabIndex = 0;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(30, 581);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(158, 57);
            addBookButton.TabIndex = 1;
            addBookButton.Text = "Add";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += AddBookButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 554);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 599);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 646);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Genre:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(301, 551);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(534, 27);
            titleTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(301, 599);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(534, 27);
            authorTextBox.TabIndex = 7;
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(301, 643);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(534, 27);
            genreTextBox.TabIndex = 8;
            // 
            // AdminBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 694);
            Controls.Add(genreTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addBookButton);
            Controls.Add(booksGridView);
            Name = "AdminBooksForm";
            Text = "AdminBooksForm";
            ((System.ComponentModel.ISupportInitialize)booksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView booksGridView;
        private Button addBookButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox genreTextBox;
    }
}