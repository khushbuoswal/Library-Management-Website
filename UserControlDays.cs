using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();

            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void day(int numday)
        {
            label1.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
    }
}
