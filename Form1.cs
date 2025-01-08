namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeLandingPage();
        }

        private void InitializeLandingPage()
        {
            this.Text = "Library Management System - Home";
            this.Size = new System.Drawing.Size(914, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            Label lblWelcome = new Label
            {
                Text = "Welcome to the Library Management System",
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(50, 50)
            };
            this.Controls.Add(lblWelcome);
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addbook add = new Addbook();
            add.Show();
        }

        private void checkOutBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBook borrow = new BorrowBook();
            borrow.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end your session?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BView bview = new BView();
            bview.Show();
        }

        private void addPatronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void viewPatronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent();
            viewStudent.Show();
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting reportingForm = new Reporting();
            reportingForm.Show();
        }

        private void roomBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomBooking roomBookingForm = new RoomBooking();
            roomBookingForm.Show();
        }
    }
}
