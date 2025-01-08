using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp6
{
    public partial class BookingForm : Form
    {
        String connectionString = "server=localhost;user id=root; database=sys;sslmode=none;password=khoai2003";
        public BookingForm()
        {
            InitializeComponent();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            txtdate.Text = RoomBooking.static_year + "/" + RoomBooking.static_month + "/" + UserControlDays.static_day;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtroom.Text) || string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    if (conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Failed to open database connection.");
                        return;
                    }
                    String sql = "INSERT INTO bookings(booking_date,booking_room,booking_name)VALUES(@booking_date,@booking_room,@booking_name)";
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@booking_date", txtdate.Text);
                    cmd.Parameters.AddWithValue("@booking_room", txtroom.Text);
                    cmd.Parameters.AddWithValue("@booking_name", txtname.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking saved");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error saving booking: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }
    }
}
