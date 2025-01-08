using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Optional: Implement if needed
        }

        // BorrowBook_Load event handler
        private void BorrowBook_Load(object sender, EventArgs e)
        {
            try
            {
                // Define the SQL query to retrieve BookID and Book Title
                string query = "SELECT bid, btitle FROM AddBook";

                using (SqlConnection connection = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open(); // Open the database connection

                    // Execute the query and load data into a DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable booksTable = new DataTable();
                    adapter.Fill(booksTable);

                    // Bind the DataTable to the ComboBox
                    BorrowBookName.DisplayMember = "btitle"; // What the user sees
                    BorrowBookName.ValueMember = "bid";       // The underlying value
                    BorrowBookName.DataSource = booksTable;

                    // Optional: Set ComboBox to have no selection initially
                    BorrowBookName.SelectedIndex = -1;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button2_Click event handler (Search Student)
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BorrowStudentId.Text))
            {
                string studentIdInput = BorrowStudentId.Text.Trim();

                // Validate that studentId is numeric (since studentid is BIGINT)
                if (!long.TryParse(studentIdInput, out long studentId))
                {
                    MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Define the SQL query to retrieve student details
                string query = "SELECT studentname, degree, email FROM AddStudent WHERE studentid = @studentid";

                try
                {
                    using (SqlConnection connection = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@studentid", studentId);

                        connection.Open(); // Open the connection

                        // Execute the query and read the data
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Populate the textboxes with the retrieved values
                            BorrowStudentName.Text = reader["studentname"].ToString();
                            DegreeBorrow.Text = reader["degree"].ToString();
                            EmailBorrow.Text = reader["email"].ToString();
                        }
                        else
                        {
                            // Clear textboxes and show error if no matching student found
                            BorrowStudentName.Clear();
                            DegreeBorrow.Clear();
                            EmailBorrow.Clear();
                            MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close(); // Close the data reader
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Student ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BorrowStudentId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BorrowStudentId.Text))
            {
                BorrowStudentName.Clear();
                DegreeBorrow.Clear();
                EmailBorrow.Clear();
            }
        }

        // buttonborrow_Click event handler (Borrow Book)
        private void buttonborrow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BorrowStudentName.Text))
            {
                if (BorrowBookName.SelectedIndex != -1)
                {
                    string studentIdInput = BorrowStudentId.Text.Trim();

                    // Validate that studentId is numeric
                    if (!int.TryParse(studentIdInput, out int studentId))
                    {
                        MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string studentName = BorrowStudentName.Text.Trim();
                    string degree = DegreeBorrow.Text.Trim();
                    string email = EmailBorrow.Text.Trim();

                    // Retrieve the selected BookID from the ComboBox
                    if (BorrowBookName.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a valid book.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int bookId = (int)BorrowBookName.SelectedValue;

                    // Retrieve the borrow date from the DateTimePicker
                    DateTime borrowDate = BorrowBookDate.Value;

                    // Define the SQL query to insert a new borrow record
                    string query = "INSERT INTO BorrowBook(student_id, student_name, student_degree, student_email, BookID, borrow_date) " +
                                   "VALUES(@studentId, @studentName, @degree, @studentEmail, @BookID, @borrowDate)";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to prevent SQL injection
                            command.Parameters.AddWithValue("@studentId", studentId);
                            command.Parameters.AddWithValue("@studentName", studentName);
                            command.Parameters.AddWithValue("@degree", degree);
                            command.Parameters.AddWithValue("@studentEmail", email);
                            command.Parameters.AddWithValue("@BookID", bookId);
                            command.Parameters.AddWithValue("@borrowDate", borrowDate);

                            connection.Open(); // Open the connection

                            // Execute the insert command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book borrowing details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Optionally, clear the form fields after successful insertion
                                BorrowStudentId.Clear();
                                BorrowStudentName.Clear();
                                DegreeBorrow.Clear();
                                EmailBorrow.Clear();
                                BorrowBookName.SelectedIndex = -1;
                                BorrowBookDate.Value = DateTime.Now; // Reset to current date if desired
                            }
                            else
                            {
                                MessageBox.Show("Failed to add borrowing details. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book name.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please ensure the student's details are filled correctly.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog box
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicked 'Yes', close the form
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
