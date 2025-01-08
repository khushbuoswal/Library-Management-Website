namespace WinFormsApp6
{
    partial class ReturnBook
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBorrowedBooks = new DataGridView();
            btnReturn = new Button();
            lblSelectBook = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(38, 88);
            dgvBorrowedBooks.Margin = new Padding(4, 4, 4, 4);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.RowTemplate.Height = 29;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(925, 375);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReturn.BackColor = Color.FromArgb(224, 224, 224);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReturn.Location = new Point(38, 488);
            btnReturn.Margin = new Padding(4, 4, 4, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(925, 62);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Selected Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblSelectBook
            // 
            lblSelectBook.AutoSize = true;
            lblSelectBook.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblSelectBook.Location = new Point(38, 38);
            lblSelectBook.Margin = new Padding(4, 0, 4, 0);
            lblSelectBook.Name = "lblSelectBook";
            lblSelectBook.Size = new Size(342, 33);
            lblSelectBook.TabIndex = 2;
            lblSelectBook.Text = "Select a Book to Return:";
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(lblSelectBook);
            Controls.Add(btnReturn);
            Controls.Add(dgvBorrowedBooks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Book";
            Load += ReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Button btnReturn;
        private Label lblSelectBook;
    }
}
