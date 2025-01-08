using System.Globalization;

namespace WinFormsApp6
{
    public partial class RoomBooking : Form
    {
        int month, year;
        public static int static_month, static_year;
        public RoomBooking()
        {
            InitializeComponent();
        }
        private void RoomBooking_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private int GetDayOfWeekIndex(DateTime date)
        {
            int dayOfWeek = (int)date.DayOfWeek;
            if (dayOfWeek == 0)
                return 7;
            else
                return dayOfWeek;
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            static_month = month;
            static_year = year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = GetDayOfWeekIndex(startofthemonth);
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlDays uc1 = new UserControlDays();
                flowLayoutPanel1.Controls.Add(uc1);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.day(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }
        private void btnprevious_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = GetDayOfWeekIndex(startofthemonth);
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc1 = new UserControl1();
                flowLayoutPanel1.Controls.Add(uc1);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.day(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }

        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = GetDayOfWeekIndex(startofthemonth);
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 uc1 = new UserControl1();
                flowLayoutPanel1.Controls.Add(uc1);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.day(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }

        }
    }
}
