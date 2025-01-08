namespace WinFormsApp6
{
    partial class Reporting
    {
        private System.ComponentModel.IContainer components = null;

        // Essential Controls
        private Panel panel1;
        private Label label6;
        private Button btnBooksReport;
        private Button btnPatronsReport;
        private Button btnBorrowedBooksReport;
        private Button btnBorrowHistoryReport; // New Button
        private Button btnExportChart; // New Button
        private DataGridView dataGridViewReports;
        private ComboBox cmbGenreFilter;
        private ScottPlot.FormsPlot formsPlotPopularBooks;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                dataGridViewReports.Dispose();
                formsPlotPopularBooks.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBooksReport = new System.Windows.Forms.Button();
            this.btnPatronsReport = new System.Windows.Forms.Button();
            this.btnBorrowedBooksReport = new System.Windows.Forms.Button();
            this.btnBorrowHistoryReport = new System.Windows.Forms.Button(); // Initialize New Button
            this.btnExportChart = new System.Windows.Forms.Button(); // Initialize Export Button
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.cmbGenreFilter = new System.Windows.Forms.ComboBox();
            this.formsPlotPopularBooks = new ScottPlot.FormsPlot(); // Initialize ScottPlot control
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 90);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.label6.Location = new System.Drawing.Point(350, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Reporting";
            // 
            // btnBooksReport
            // 
            this.btnBooksReport.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.btnBooksReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooksReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnBooksReport.Location = new System.Drawing.Point(44, 112);
            this.btnBooksReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBooksReport.Name = "btnBooksReport";
            this.btnBooksReport.Size = new System.Drawing.Size(131, 30);
            this.btnBooksReport.TabIndex = 1;
            this.btnBooksReport.Text = "Books Report";
            this.btnBooksReport.UseVisualStyleBackColor = false;
            this.btnBooksReport.Click += new System.EventHandler(this.btnBooksReport_Click);
            // 
            // btnPatronsReport
            // 
            this.btnPatronsReport.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.btnPatronsReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPatronsReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnPatronsReport.Location = new System.Drawing.Point(44, 158);
            this.btnPatronsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatronsReport.Name = "btnPatronsReport";
            this.btnPatronsReport.Size = new System.Drawing.Size(131, 30);
            this.btnPatronsReport.TabIndex = 2;
            this.btnPatronsReport.Text = "Patrons Report";
            this.btnPatronsReport.UseVisualStyleBackColor = false;
            this.btnPatronsReport.Click += new System.EventHandler(this.btnPatronsReport_Click);
            // 
            // btnBorrowedBooksReport
            // 
            this.btnBorrowedBooksReport.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.btnBorrowedBooksReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrowedBooksReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnBorrowedBooksReport.Location = new System.Drawing.Point(44, 202);
            this.btnBorrowedBooksReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrowedBooksReport.Name = "btnBorrowedBooksReport";
            this.btnBorrowedBooksReport.Size = new System.Drawing.Size(131, 30);
            this.btnBorrowedBooksReport.TabIndex = 3;
            this.btnBorrowedBooksReport.Text = "Borrowed Books Report";
            this.btnBorrowedBooksReport.UseVisualStyleBackColor = false;
            this.btnBorrowedBooksReport.Click += new System.EventHandler(this.btnBorrowedBooksReport_Click);
            // 
            // btnBorrowHistoryReport
            // 
            this.btnBorrowHistoryReport.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.btnBorrowHistoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrowHistoryReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnBorrowHistoryReport.Location = new System.Drawing.Point(44, 248); // Adjust position as needed
            this.btnBorrowHistoryReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrowHistoryReport.Name = "btnBorrowHistoryReport";
            this.btnBorrowHistoryReport.Size = new System.Drawing.Size(131, 30);
            this.btnBorrowHistoryReport.TabIndex = 4;
            this.btnBorrowHistoryReport.Text = "Borrow History Report";
            this.btnBorrowHistoryReport.UseVisualStyleBackColor = false;
            this.btnBorrowHistoryReport.Click += new System.EventHandler(this.btnBorrowHistoryReport_Click);
            // 
            // btnExportChart
            // 
            this.btnExportChart.BackColor = System.Drawing.Color.LightGreen;
            this.btnExportChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportChart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnExportChart.Location = new System.Drawing.Point(44, 294); // Adjust position as needed
            this.btnExportChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportChart.Name = "btnExportChart";
            this.btnExportChart.Size = new System.Drawing.Size(131, 30);
            this.btnExportChart.TabIndex = 5;
            this.btnExportChart.Text = "Export Chart";
            this.btnExportChart.UseVisualStyleBackColor = false;
            this.btnExportChart.Click += new System.EventHandler(this.btnExportChart_Click);
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.BackgroundColor = System.Drawing.Color.FromArgb(192, 192, 255);
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Location = new System.Drawing.Point(192, 150);
            this.dataGridViewReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.ReadOnly = true;
            this.dataGridViewReports.Size = new System.Drawing.Size(656, 338);
            this.dataGridViewReports.TabIndex = 6;
            // 
            // cmbGenreFilter
            // 
            this.cmbGenreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenreFilter.FormattingEnabled = true;
            this.cmbGenreFilter.Location = new System.Drawing.Point(192, 112);
            this.cmbGenreFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenreFilter.Name = "cmbGenreFilter";
            this.cmbGenreFilter.Size = new System.Drawing.Size(176, 23);
            this.cmbGenreFilter.TabIndex = 7;
            // 
            // formsPlotPopularBooks
            // 
            this.formsPlotPopularBooks.Location = new System.Drawing.Point(192, 470);
            this.formsPlotPopularBooks.Name = "formsPlotPopularBooks";
            this.formsPlotPopularBooks.Size = new System.Drawing.Size(656, 300);
            this.formsPlotPopularBooks.TabIndex = 8;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(875, 800); // Adjusted to accommodate the chart
            this.Controls.Add(this.formsPlotPopularBooks); // Add ScottPlot control
            this.Controls.Add(this.cmbGenreFilter);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.btnExportChart);
            this.Controls.Add(this.btnBorrowHistoryReport);
            this.Controls.Add(this.btnBorrowedBooksReport);
            this.Controls.Add(this.btnPatronsReport);
            this.Controls.Add(this.btnBooksReport);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reporting";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.Reporting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}