using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp6
{
    public partial class Reporting : Form
    {
        private readonly string connectionString = "Server=tcp:library-management.database.windows.net,1433;Initial Catalog=library;Persist Security Info=False;User ID=choonga;Password=Useless1211#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Reporting()
        {
            InitializeComponent();
        }

        private async void Reporting_Load(object sender, EventArgs e)
        {
            dataGridViewReports.Visible = false;

            // Populate Genre Filter ComboBox
            await PopulateGenreFilterAsync();
            LoadPopularBooksChart();
        }

        /// <summary>
        /// Populates the Genre Filter ComboBox with distinct genres from AddBook table.
        /// </summary>
        private async Task PopulateGenreFilterAsync()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT bgenre FROM AddBook";
                    SqlCommand cmd = new SqlCommand(query, con);
                    await con.OpenAsync();
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    cmbGenreFilter.Items.Clear();
                    cmbGenreFilter.Items.Add("All Genres");

                    while (await reader.ReadAsync())
                    {
                        cmbGenreFilter.Items.Add(reader["bgenre"].ToString());
                    }

                    cmbGenreFilter.SelectedIndex = 0; 
                    reader.Close(); 
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error populating genre filter: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error populating genre filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Generates and displays the Books Report based on selected genre.
        /// </summary>
        private async void btnBooksReport_Click(object sender, EventArgs e)
        {
            string selectedGenre = cmbGenreFilter.SelectedItem.ToString();
            string query = "SELECT bid AS [Book ID], btitle AS [Title], bauthor AS [Author], bgenre AS [Genre], bpurchasedate AS [Purchase Date], bavailable AS [Available], bprice AS [Price] FROM AddBook";

            if (selectedGenre != "All Genres")
            {
                query += " WHERE bgenre = @bgenre";
            }

            await GenerateReportAsync(query, "Books Report", selectedGenre);
        }

        /// <summary>
        /// Generates and displays the Patrons Report.
        /// </summary>
        private async void btnPatronsReport_Click(object sender, EventArgs e)
        {
            string query = "SELECT id AS [Patron ID], studentname AS [Name], studentid AS [Student ID], contact AS [Contact Number], degree AS [Degree], email AS [Email] FROM AddStudent";
            await GenerateReportAsync(query, "Patrons Report");
        }

        /// <summary>
        /// Generates and displays the Borrowed Books Report.
        /// </summary>
        private async void btnBorrowedBooksReport_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    bb.id AS [Borrow ID],
                    s.studentname AS [Student Name],
                    s.studentid AS [Student ID],
                    s.contact AS [Contact Number],
                    s.degree AS [Degree],
                    s.email AS [Email],
                    b.btitle AS [Book Title],
                    b.bpurchasedate AS [Purchase Date],
                    bb.student_id AS [Student ID (FK)]
                FROM 
                    BorrowBook bb
                LEFT JOIN 
                    AddStudent s ON bb.student_id = s.studentid
                LEFT JOIN 
                    AddBook b ON bb.BookID = b.bid
                WHERE 
                    bb.returnDate IS NULL";

            await GenerateReportAsync(query, "Borrowed Books Report");
        }

        /// <summary>
        /// Generates and displays the Borrow History Report showing all borrowing records.
        /// </summary>
        private async void btnBorrowHistoryReport_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    bb.id AS [Borrow ID],
                    s.studentname AS [Student Name],
                    s.studentid AS [Student ID],
                    s.contact AS [Contact Number],
                    s.degree AS [Degree],
                    s.email AS [Email],
                    b.btitle AS [Book Title],
                    b.bpurchasedate AS [Purchase Date],
                    bb.borrow_date AS [Borrow Date],
                    bb.returnDate AS [Return Date]
                FROM 
                    BorrowBook bb
                LEFT JOIN 
                    AddStudent s ON bb.student_id = s.studentid
                LEFT JOIN 
                    AddBook b ON bb.BookID = b.bid
                ORDER BY 
                    bb.borrow_date DESC";

            await GenerateReportAsync(query, "Borrow History Report");
        }

        /// <summary>
        /// Executes the given SQL query and displays the results in the DataGridView.
        /// </summary>
        private async Task GenerateReportAsync(string query, string reportName, string genre = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(genre) && genre != "All Genres")
                        {
                            cmd.Parameters.AddWithValue("@bgenre", genre);
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            await Task.Run(() => da.Fill(dt)); // Asynchronously fill the DataTable

                            dataGridViewReports.Invoke((Action)(() =>
                            {
                                dataGridViewReports.DataSource = dt;
                                dataGridViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridViewReports.Visible = true;
                            }));

                            this.Invoke((Action)(() => this.Text = reportName));
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error generating {reportName}: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error generating {reportName}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads data into the Popular Books chart using ScottPlot.
        /// </summary>
        private void LoadPopularBooksChart()
        {
            string query = @"
                SELECT TOP 10 
                    AddBook.btitle AS [Title], 
                    COUNT(BorrowBook.id) AS [BorrowCount]
                FROM 
                    BorrowBook
                INNER JOIN 
                    AddBook ON BorrowBook.BookID = AddBook.bid
                GROUP BY 
                    AddBook.btitle
                ORDER BY 
                    BorrowCount DESC";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        var titles = new List<string>();
                        var counts = new List<int>();

                        while (reader.Read())
                        {
                            titles.Add(reader["Title"].ToString());
                            counts.Add(Convert.ToInt32(reader["BorrowCount"]));
                        }

                        reader.Close();

                        double[] yValues = counts.Select(count => (double)count).ToArray();
                        string[] xLabels = titles.ToArray();
                        double[] positions = Enumerable.Range(0, xLabels.Length).Select(i => (double)i).ToArray();

                        formsPlotPopularBooks.Plot.Clear();

                        var bar = formsPlotPopularBooks.Plot.AddBar(yValues);

                        bar.FillColor = System.Drawing.Color.FromArgb(100, 72, 61, 139);
                        bar.BorderColor = System.Drawing.Color.DarkBlue;

                        formsPlotPopularBooks.Plot.XTicks(positions, xLabels);

                        formsPlotPopularBooks.Plot.Title("Top 10 Most Borrowed Books");
                        formsPlotPopularBooks.Plot.YLabel("Number of Borrows");
                        formsPlotPopularBooks.Plot.XLabel("Book Title");

                        formsPlotPopularBooks.Plot.SetAxisLimits(yMin: 0);
                        formsPlotPopularBooks.Refresh();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error loading popular books chart: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error loading popular books chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Exports the current chart as an image.
        /// </summary>
        private void btnExportChart_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
                saveFileDialog.Title = "Save Chart as Image";
                saveFileDialog.FileName = "PopularBooksChart.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Save the ScottPlot chart as an image
                        formsPlotPopularBooks.Plot.SaveFig(saveFileDialog.FileName);
                        MessageBox.Show("Chart saved successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving chart: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
