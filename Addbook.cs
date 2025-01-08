using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog with "Yes" and "No" buttons
            DialogResult result = MessageBox.Show("This will delete your unsaved data. Are you sure you want to proceed?",
                                                  "Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the form if the user clicked "Yes"
            }
            // If the user clicked "No", do nothing (i.e., do not close the form)
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            String btitle = texttitle.Text;
            String bauthor = textAuthorName.Text;
            String bgenre = textGenre.Text;

            if (string.IsNullOrWhiteSpace(btitle) || string.IsNullOrWhiteSpace(bauthor) ||
                string.IsNullOrWhiteSpace(bgenre) || string.IsNullOrWhiteSpace(textdate.Text) ||
                string.IsNullOrWhiteSpace(textAvailable.Text) || string.IsNullOrWhiteSpace(textBookprice.Text))
            {
                MessageBox.Show("Empty textboxes are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Convert textdate.Text to DateTime safely using TryParse
            DateTime bpurchasedate;
            if (!DateTime.TryParse(textdate.Text, out bpurchasedate))
            {
                MessageBox.Show("Invalid date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert textAvailable.Text to Int64 safely using TryParse
            Int64 bavailable;
            if (!Int64.TryParse(textAvailable.Text, out bavailable))
            {
                MessageBox.Show("Invalid number format for available quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert textBookprice.Text to decimal safely using TryParse
            decimal bprice;
            if (!decimal.TryParse(textBookprice.Text, out bprice))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call SaveData method to save book information
            SaveData(btitle, bauthor, bgenre, bpurchasedate, bavailable, bprice);
        }

        // Overloaded SaveData method for saving book information
        public void SaveData(string btitle, string bauthor, string bgenre, DateTime bpurchasedate, long bavailable, decimal bprice)
        {
            // Define SQL connection and command
            SqlConnection con = new SqlConnection("Server=tcp:your_server.database.windows.net,1433;Initial Catalog=loan;Persist Security Info=False;User ID=your_username;Password=your_password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand cmd = new SqlCommand("insert into AddBook (btitle, bauthor, bgenre, bpurchasedate, bavailable, bprice) values (@btitle, @bauthor, @bgenre, @bpurchasedate, @bavailable, @bprice)", con);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@btitle", btitle);
            cmd.Parameters.AddWithValue("@bauthor", bauthor);
            cmd.Parameters.AddWithValue("@bgenre", bgenre);
            cmd.Parameters.AddWithValue("@bpurchasedate", bpurchasedate);
            cmd.Parameters.AddWithValue("@bavailable", bavailable);
            cmd.Parameters.AddWithValue("@bprice", bprice);

            ExecuteCommand(con, cmd);
        }

        // Shared method to execute the SQL command
        private void ExecuteCommand(SqlConnection con, SqlCommand cmd)
        {
            // Execute the query
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                texttitle.Text = "";
                textAuthorName.Text = "";
                textGenre.Text = "";
                textdate.Text = "";
                textAvailable.Text = "";
                textBookprice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
