using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class BView : Form
    {
        public BView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Available_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Ensure 'bid' has a valid value before proceeding
                string btitle = textttl.Text;
                string bauthor = textan.Text;
                string bgenre = textG.Text;
                DateTime bpurchasedate = DateTime.Parse(textpd.Text); // Convert text to DateTime
                Int64 bavailable = Int64.Parse(texta.Text);
                Decimal bprice = Decimal.Parse(textp.Text); // Convert text to Int64

                // Establish database connection and update the record
                using (SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    con.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE AddBook SET btitle = @btitle, bauthor = @bauthor, bgenre = @bgenre, bpurchasedate = @bpurchasedate, bavailable = @bavailable, bprice = @bprice WHERE bid = @rowid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Bind parameters with actual values
                        cmd.Parameters.AddWithValue("@btitle", btitle);
                        cmd.Parameters.AddWithValue("@bauthor", bauthor);
                        cmd.Parameters.AddWithValue("@bgenre", bgenre);
                        cmd.Parameters.AddWithValue("@bpurchasedate", bpurchasedate);
                        cmd.Parameters.AddWithValue("@bavailable", bavailable);
                        cmd.Parameters.AddWithValue("@bprice", bprice);
                        cmd.Parameters.AddWithValue("@rowid", rowid);  // Pass rowid safely as a parameter

                        // Execute the update command
                        cmd.ExecuteNonQuery();
                    }

                    con.Close(); // Close the connection
                }
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BView_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT * FROM AddBook";

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
                            dataGridView1.DataSource = dataSet.Tables[0];
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

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure that a valid cell is clicked and not null
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int bookId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                using (SqlConnection connection = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    connection.Open();

                    string query = "SELECT * FROM AddBook WHERE bid = @bookId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Using parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@bookId", bookId);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        // Assuming there is at least one row in the result set
                        if (dataSet.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables[0].Rows[0];

                            rowid = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                            // Populate textboxes with the appropriate data from the row
                            textttl.Text = row["btitle"].ToString();
                            textan.Text = row["bauthor"].ToString();
                            textG.Text = row["bgenre"].ToString();
                            textpd.Text = row["bpurchaseDate"].ToString();
                            texta.Text = row["bavailable"].ToString();
                            textp.Text = row["bprice"].ToString();
                        }
                    }
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttoncl_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
        }
        private void textholder_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password={Useless1211#};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                con.Open();
                string query = "SELECT * FROM AddBook";

                // Use parameterized query to avoid SQL injection
                if (!string.IsNullOrEmpty(textholder.Text))
                {
                    query += " WHERE btitle LIKE @btitle";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(textholder.Text))
                    {
                        cmd.Parameters.AddWithValue("@btitle", textholder.Text + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    // Assuming you want to display the data in a DataGridView, you could bind the dataset like this:
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void buttondl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Establish database connection and delete the record
                using (SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    con.Open();

                    // Use parameterized query to safely delete the record
                    string query = "DELETE FROM AddBook WHERE bid = @rowid";

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
