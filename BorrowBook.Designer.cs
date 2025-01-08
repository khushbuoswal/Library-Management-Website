namespace WinFormsApp6
{
    partial class BorrowBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label2 = new Label();
            BorrowStudentId = new TextBox();
            Exit = new Button();
            panel3 = new Panel();
            EmailBorrow = new TextBox();
            DegreeBorrow = new TextBox();
            BorrowBookName = new ComboBox();
            BorrowBookDate = new DateTimePicker();
            buttonborrow = new Button();
            BorrowStudentName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 149);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 0;
            label1.Text = "Borrow Book";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BorrowStudentId);
            panel2.Location = new Point(4, 159);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 188);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(752, 29);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 1;
            label2.Text = "Student Id";
            // 
            // BorrowStudentId
            // 
            BorrowStudentId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BorrowStudentId.Location = new Point(525, 29);
            BorrowStudentId.Margin = new Padding(4);
            BorrowStudentId.Name = "BorrowStudentId";
            BorrowStudentId.Size = new Size(196, 35);
            BorrowStudentId.TabIndex = 0;
            BorrowStudentId.TextChanged += BorrowStudentId_TextChanged;
            // 
            // Exit
            // 
            Exit.FlatStyle = FlatStyle.Popup;
            Exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(820, 222);
            Exit.Margin = new Padding(4);
            Exit.Name = "Exit";
            Exit.Size = new Size(118, 49);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(EmailBorrow);
            panel3.Controls.Add(Exit);
            panel3.Controls.Add(DegreeBorrow);
            panel3.Controls.Add(BorrowBookName);
            panel3.Controls.Add(BorrowBookDate);
            panel3.Controls.Add(buttonborrow);
            panel3.Controls.Add(BorrowStudentName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(4, 354);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1135, 322);
            panel3.TabIndex = 2;
            // 
            // EmailBorrow
            // 
            EmailBorrow.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBorrow.Location = new Point(221, 224);
            EmailBorrow.Margin = new Padding(4);
            EmailBorrow.Name = "EmailBorrow";
            EmailBorrow.ReadOnly = true;
            EmailBorrow.Size = new Size(322, 35);
            EmailBorrow.TabIndex = 12;
            // 
            // DegreeBorrow
            // 
            DegreeBorrow.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DegreeBorrow.Location = new Point(221, 132);
            DegreeBorrow.Margin = new Padding(4);
            DegreeBorrow.Name = "DegreeBorrow";
            DegreeBorrow.ReadOnly = true;
            DegreeBorrow.Size = new Size(322, 35);
            DegreeBorrow.TabIndex = 11;
            // 
            // BorrowBookName
            // 
            BorrowBookName.Cursor = Cursors.SizeNS;
            BorrowBookName.DropDownStyle = ComboBoxStyle.DropDownList;
            BorrowBookName.FormattingEnabled = true;
            BorrowBookName.Location = new Point(775, 28);
            BorrowBookName.Margin = new Padding(4);
            BorrowBookName.Name = "BorrowBookName";
            BorrowBookName.Size = new Size(312, 33);
            BorrowBookName.TabIndex = 10;
            // 
            // BorrowBookDate
            // 
            BorrowBookDate.Location = new Point(775, 128);
            BorrowBookDate.Margin = new Padding(4);
            BorrowBookDate.Name = "BorrowBookDate";
            BorrowBookDate.Size = new Size(312, 31);
            BorrowBookDate.TabIndex = 9;
            BorrowBookDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // buttonborrow
            // 
            buttonborrow.FlatStyle = FlatStyle.Popup;
            buttonborrow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonborrow.Location = new Point(970, 222);
            buttonborrow.Margin = new Padding(4);
            buttonborrow.Name = "buttonborrow";
            buttonborrow.Size = new Size(118, 49);
            buttonborrow.TabIndex = 4;
            buttonborrow.Text = "Borrow Book";
            buttonborrow.UseVisualStyleBackColor = true;
            buttonborrow.Click += buttonborrow_Click;
            // 
            // BorrowStudentName
            // 
            BorrowStudentName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BorrowStudentName.Location = new Point(221, 39);
            BorrowStudentName.Margin = new Padding(4);
            BorrowStudentName.Name = "BorrowStudentName";
            BorrowStudentName.ReadOnly = true;
            BorrowStudentName.Size = new Size(322, 35);
            BorrowStudentName.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(569, 131);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(191, 30);
            label8.TabIndex = 5;
            label8.Text = "Borrow Book Date";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 264);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(569, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 30);
            label6.TabIndex = 3;
            label6.Text = "Book Name";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 222);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 30);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 30);
            label4.TabIndex = 1;
            label4.Text = "Degree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 30);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 691);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "BorrowBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowBook";
            Load += BorrowBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private Button Exit;
        private Label label2;
        private TextBox BorrowStudentId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox BorrowStudentName;
        private Button buttonborrow;
        private DateTimePicker BorrowBookDate;
        private ComboBox BorrowBookName;
        private TextBox EmailBorrow;
        private TextBox DegreeBorrow;
    }
}