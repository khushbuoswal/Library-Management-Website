using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WinFormsApp6
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve values from textboxes
            String studentname = textstudentname.Text;
            String degree = textstudentdegree.Text;
            String email = textstudentemail.Text;

            // Email and Contact validation using regular expressions
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert studentid and contact to Int64 safely using TryParse
            Int64 studentid;
            if (!Int64.TryParse(textstudentid.Text, out studentid))
            {
                MessageBox.Show("Invalid number format for Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Int64 contact;
            if (!Int64.TryParse(textstudentcontact.Text, out contact) || !IsValidContact(textstudentcontact.Text))
            {
                MessageBox.Show("Invalid contact number format. It should be a 10-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for empty textboxes
            if (string.IsNullOrWhiteSpace(studentname) || string.IsNullOrWhiteSpace(degree) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Empty textboxes are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call SaveData method to save student information
            SaveData(studentname, studentid, contact, degree, email);
        }
        public void SaveData(string studentname, long studentid, long contact, string degree, string email)
        {
            // Define SQL connection and command (correct table name AddStudent)
            SqlConnection con = new SqlConnection("Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand cmd = new SqlCommand("INSERT INTO AddStudent (studentname, studentid, contact, degree, email) VALUES (@studentname, @studentid, @contact, @degree, @email)", con);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@studentname", studentname);
            cmd.Parameters.AddWithValue("@studentid", studentid);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@degree", degree);
            cmd.Parameters.AddWithValue("@email", email);

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
                textstudentname.Text = "";
                textstudentid.Text = "";
                textstudentcontact.Text = "";
                textstudentdegree.Text = "";
                textstudentemail.Text = "";
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

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Method to validate contact number format (assumes a 10-digit phone number)
        private bool IsValidContact(string contact)
        {
            string contactPattern = @"^\d{10}$";
            return Regex.IsMatch(contact, contactPattern);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
