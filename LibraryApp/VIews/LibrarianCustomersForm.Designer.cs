namespace LibraryApp.VIews
{
    partial class LibrarianCustomersForm
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
            CustomerDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(5, 71);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.Size = new Size(300, 283);
            CustomerDataGridView.TabIndex = 0;
            // 
            // LibrarianCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 495);
            Controls.Add(CustomerDataGridView);
            Name = "LibrarianCustomersForm";
            Text = "LibrarianCustomersForm";
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CustomerDataGridView;
    }
}