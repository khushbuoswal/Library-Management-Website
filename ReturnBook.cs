using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        /// <summary>
        /// Loads the list of borrowed books into the DataGridView, including the return deadline.
        /// </summary>
        private void LoadBorrowedBooks()
        {
            string query = @"
                SELECT 
                    BorrowBook.id AS BorrowID,
                    AddBook.bid AS BookID,
                    AddBook.btitle AS Title,
                    AddStudent.id AS PatronID,
                    AddStudent.studentname AS Name,
                    BorrowBook.borrow_date AS BorrowDate,
                    DATEADD(day, 14, BorrowBook.borrow_date) AS ReturnDeadline
                FROM 
                    BorrowBook
                LEFT JOIN 
                    AddBook ON BorrowBook.BookID = AddBook.bid
                LEFT JOIN 
                    AddStudent ON BorrowBook.student_id = AddStudent.studentid
                WHERE 
                    BorrowBook.ReturnDate IS NULL";

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBorrowedBooks.DataSource = dt;

                    // Optionally, hide certain columns for a cleaner UI
                    if (dgvBorrowedBooks.Columns["BorrowID"] != null)
                        dgvBorrowedBooks.Columns["BorrowID"].Visible = false;
                    if (dgvBorrowedBooks.Columns["BookID"] != null)
                        dgvBorrowedBooks.Columns["BookID"].Visible = false;
                    if (dgvBorrowedBooks.Columns["PatronID"] != null)
                        dgvBorrowedBooks.Columns["PatronID"].Visible = false;

                    // Format the date columns for better readability
                    if (dgvBorrowedBooks.Columns["BorrowDate"] != null)
                        dgvBorrowedBooks.Columns["BorrowDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

                    if (dgvBorrowedBooks.Columns["ReturnDeadline"] != null)
                        dgvBorrowedBooks.Columns["ReturnDeadline"].DefaultCellStyle.Format = "yyyy-MM-dd";

                    dgvBorrowedBooks.AutoResizeColumns();

                    // Highlight overdue books
                    HighlightOverdueBooks();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error loading borrowed books: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error loading borrowed books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Highlights rows where the return deadline has passed.
        /// </summary>
        private void HighlightOverdueBooks()
        {
            foreach (DataGridViewRow row in dgvBorrowedBooks.Rows)
            {
                if (row.Cells["ReturnDeadline"].Value != DBNull.Value)
                {
                    DateTime returnDeadline = Convert.ToDateTime(row.Cells["ReturnDeadline"].Value);
                    if (returnDeadline.Date < DateTime.Now.Date)
                    {
                        // Highlight the entire row in light red
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the return of the selected book.
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count > 0)
            {
                // Confirm the return action
                DialogResult confirm = MessageBox.Show("Are you sure you want to return the selected book?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int borrowID = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells["BorrowID"].Value);

                    ReturnSelectedBook(borrowID);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Marks the selected book as returned in the database.
        /// </summary>
        /// <param name="borrowID">The BorrowID of the book to return.</param>
        private void ReturnSelectedBook(int borrowID)
        {
            string updateQuery = @"
                UPDATE BorrowBook 
                SET ReturnDate = @ReturnDate 
                WHERE id = @BorrowID";

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BorrowID", borrowID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBorrowedBooks(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to return the book. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error returning the book: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error returning the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
