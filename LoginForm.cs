namespace WinFormsApp6
{
    public partial class LoginForm : Form
    {
        private string userType;

        //Generics Collection
        private Dictionary<string, string> librarianCredentials = new Dictionary<string, string>
        {
            { "admin1", "123" },
            { "admin2", "123" }
        };

        public LoginForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            InitializeLoginForm();
        }

        private void InitializeLoginForm()
        {
            this.Text = $"{userType} Login";
            this.Size = new System.Drawing.Size(350, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblUsername = new Label
            {
                Text = "Username:",
                Location = new System.Drawing.Point(30, 50),
                AutoSize = true
            };
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox
            {
                Name = "txtUsername",
                Location = new System.Drawing.Point(120, 45),
                Width = 180
            };
            this.Controls.Add(txtUsername);

            Label lblPassword = new Label
            {
                Text = "Password:",
                Location = new System.Drawing.Point(30, 100),
                AutoSize = true
            };
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox
            {
                Name = "txtPassword",
                Location = new System.Drawing.Point(120, 95),
                Width = 180,
                PasswordChar = '*'
            };
            this.Controls.Add(txtPassword);

            Button btnLogin = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(120, 150)
            };
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = ((TextBox)this.Controls["txtUsername"]).Text;
            string password = ((TextBox)this.Controls["txtPassword"]).Text;

            bool isAuthenticated = false;

            if (userType == "Librarian")
            {
                if (librarianCredentials.ContainsKey(username) && librarianCredentials[username] == password)
                {
                    isAuthenticated = true;
                }
            }

            if (isAuthenticated)
            {
                MessageBox.Show($"Welcome, {userType} {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
