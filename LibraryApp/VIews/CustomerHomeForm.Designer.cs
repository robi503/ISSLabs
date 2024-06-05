namespace LibraryApp
{
    partial class CustomerHomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            booksGridView = new DataGridView();
            rentButton = new Button();
            LogOutButton = new Button();
            label1 = new Label();
            label2 = new Label();
            RentedBooksGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)booksGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RentedBooksGridView).BeginInit();
            SuspendLayout();
            // 
            // booksGridView
            // 
            booksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksGridView.Location = new Point(12, 73);
            booksGridView.Name = "booksGridView";
            booksGridView.RowHeadersWidth = 51;
            booksGridView.Size = new Size(1151, 225);
            booksGridView.TabIndex = 3;
            // 
            // rentButton
            // 
            rentButton.Location = new Point(504, 304);
            rentButton.Name = "rentButton";
            rentButton.Size = new Size(180, 32);
            rentButton.TabIndex = 4;
            rentButton.Text = "Rent books";
            rentButton.UseVisualStyleBackColor = true;
            rentButton.Click += RentButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = SystemColors.Desktop;
            LogOutButton.ForeColor = SystemColors.ControlLightLight;
            LogOutButton.Location = new Point(504, 596);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(180, 35);
            LogOutButton.TabIndex = 6;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 7;
            label1.Text = "Available books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 383);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 8;
            label2.Text = "Your rented books";
            // 
            // RentedBooksGridView
            // 
            RentedBooksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RentedBooksGridView.Location = new Point(12, 420);
            RentedBooksGridView.Name = "RentedBooksGridView";
            RentedBooksGridView.RowHeadersWidth = 51;
            RentedBooksGridView.Size = new Size(1151, 170);
            RentedBooksGridView.TabIndex = 9;
            // 
            // CustomerHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 651);
            Controls.Add(RentedBooksGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogOutButton);
            Controls.Add(rentButton);
            Controls.Add(booksGridView);
            Name = "CustomerHomeForm";
            Text = "Available books";
            ((System.ComponentModel.ISupportInitialize)booksGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)RentedBooksGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView booksGridView;
        private Button rentButton;
        private Button LogOutButton;
        private Label label1;
        private Label label2;
        private DataGridView RentedBooksGridView;
    }
}
