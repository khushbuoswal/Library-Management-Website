using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = DESKTOP-C8LBMTF\\SQLEXPRESS; database = loan; integrated security = True"))
            {
                con.Open();
                string query = "SELECT * FROM AddStudent";

                // Use parameterized query to avoid SQL injection
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    query += " WHERE studentid LIKE @studentid";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cmd.Parameters.AddWithValue("@studentid", textBox1.Text + "%");
                    }

                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    dataadapter.Fill(dataset);

                    // Assuming you want to display the data in a DataGridView, you could bind the dataset like this:
                    dataGV.DataSource = dataset.Tables[0];
                }
            }
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT * FROM AddStudent";

            // Use 'using' for automatic resource management of SqlConnection, SqlCommand, and SqlDataAdapter
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);

                            // Bind the data to the DataGridView
                            dataGV.DataSource = dataSet.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (log them, display an error message, etc.)
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        int said;
        Int64 rowid;

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Ensure that a valid cell is clicked and not null
            if (dataGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int sid = Convert.ToInt32(dataGV.Rows[e.RowIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    connection.Open();

                    string query = "SELECT * FROM AddStudent WHERE id = @sid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Using parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@sid", sid);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        // Assuming there is at least one row in the result set
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables[0].Rows[0];

                            rowid = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                            // Populate textboxes with the appropriate data from the row
                            textsn.Text = row["studentname"].ToString();
                            textsi.Text = row["studentid"].ToString();
                            textc.Text = row["contact"].ToString();
                            textd.Text = row["degree"].ToString();
                            texte.Text = row["email"].ToString();

                        }
                    }
                }
            }
        }

        private void buttonup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Ensure values have valid types before proceeding
                string studentname = textsn.Text;               // Student name as string
                Int64 studentid = Int64.Parse(textsi.Text);     // Student ID as Int64 (BIGINT)
                Int64 contact = Int64.Parse(textc.Text);        // Contact number as Int64 (BIGINT)
                string degree = textd.Text;                     // Degree as string
                string email = texte.Text;                      // Email as string


                // Establish database connection and update the record
                using (SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    con.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE AddStudent SET studentname = @studentname, studentid = @studentid, contact = @contact, degree = @degree, email = @email WHERE id = @rowid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Bind parameters with actual values
                        cmd.Parameters.AddWithValue("@studentname", studentname);
                        cmd.Parameters.AddWithValue("@studentid", studentid);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@degree", degree);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@rowid", rowid);  // Pass rowid safely as a parameter

                        // Execute the update command
                        cmd.ExecuteNonQuery();
                    }

                    con.Close(); // Close the connection
                }
            }
        }

        private void buttondlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Establish database connection and delete the record
                using (SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    con.Open();

                    // Use parameterized query to safely delete the record
                    string query = "DELETE FROM AddStudent WHERE id = @rowid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Bind the rowid parameter to safely identify the record to delete
                        cmd.Parameters.AddWithValue("@rowid", rowid);  // Pass rowid safely as a parameter

                        // Execute the delete command
                        cmd.ExecuteNonQuery();
                    }

                    con.Close(); // Close the connection
                }
            }
        }
    }
}
