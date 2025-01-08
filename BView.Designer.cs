namespace WinFormsApp6
{
    partial class BView
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
            label6 = new Label();
            label1 = new Label();
            textholder = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Available = new Label();
            textttl = new TextBox();
            textG = new TextBox();
            texta = new TextBox();
            textp = new TextBox();
            textan = new TextBox();
            textpd = new DateTimePicker();
            label7 = new Label();
            buttonut = new Button();
            buttondl = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-4, -1);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 174);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(464, 42);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(267, 55);
            label6.TabIndex = 22;
            label6.Text = "VIEW BOOKS";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 2;
            label1.Text = "Book Title";
            // 
            // textholder
            // 
            textholder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textholder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textholder.Location = new Point(420, 170);
            textholder.Margin = new Padding(4, 4, 4, 4);
            textholder.Name = "textholder";
            textholder.Size = new Size(347, 35);
            textholder.TabIndex = 4;
            textholder.TextChanged += textholder_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 250);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1166, 314);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(29, 594);
            dataGridView2.Margin = new Padding(4, 4, 4, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1166, 364);
            dataGridView2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 614);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 7;
            label2.Text = "Book Title";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 714);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 8;
            label3.Text = "Author Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 816);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 9;
            label4.Text = "Genre";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 255);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(638, 614);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 32);
            label5.TabIndex = 10;
            label5.Text = "Purchase Date";
            // 
            // Available
            // 
            Available.AccessibleRole = AccessibleRole.PageTabList;
            Available.AutoSize = true;
            Available.BackColor = Color.FromArgb(192, 192, 255);
            Available.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Available.Location = new Point(638, 711);
            Available.Margin = new Padding(4, 0, 4, 0);
            Available.Name = "Available";
            Available.Size = new Size(110, 32);
            Available.TabIndex = 11;
            Available.Text = "Available";
            Available.Click += Available_Click;
            // 
            // textttl
            // 
            textttl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textttl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textttl.Location = new Point(244, 614);
            textttl.Margin = new Padding(4, 4, 4, 4);
            textttl.Name = "textttl";
            textttl.Size = new Size(312, 35);
            textttl.TabIndex = 12;
            // 
            // textG
            // 
            textG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textG.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textG.Location = new Point(244, 801);
            textG.Margin = new Padding(4, 4, 4, 4);
            textG.Name = "textG";
            textG.Size = new Size(312, 35);
            textG.TabIndex = 13;
            textG.TextChanged += textBox4_TextChanged;
            // 
            // texta
            // 
            texta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            texta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texta.Location = new Point(814, 714);
            texta.Margin = new Padding(4, 4, 4, 4);
            texta.Name = "texta";
            texta.Size = new Size(312, 35);
            texta.TabIndex = 14;
            // 
            // textp
            // 
            textp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textp.Location = new Point(814, 801);
            textp.Margin = new Padding(4, 4, 4, 4);
            textp.Name = "textp";
            textp.Size = new Size(312, 35);
            textp.TabIndex = 15;
            textp.TextChanged += textBox6_TextChanged;
            // 
            // textan
            // 
            textan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textan.Location = new Point(244, 719);
            textan.Margin = new Padding(4, 4, 4, 4);
            textan.Name = "textan";
            textan.Size = new Size(312, 35);
            textan.TabIndex = 16;
            // 
            // textpd
            // 
            textpd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textpd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpd.Location = new Point(814, 614);
            textpd.Margin = new Padding(4, 4, 4, 4);
            textpd.Name = "textpd";
            textpd.Size = new Size(312, 35);
            textpd.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 192, 255);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(638, 804);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 32);
            label7.TabIndex = 18;
            label7.Text = "Book Price";
            label7.Click += label7_Click;
            // 
            // buttonut
            // 
            buttonut.BackColor = Color.FromArgb(192, 192, 255);
            buttonut.FlatStyle = FlatStyle.Popup;
            buttonut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonut.Location = new Point(652, 886);
            buttonut.Margin = new Padding(4, 4, 4, 4);
            buttonut.Name = "buttonut";
            buttonut.Size = new Size(118, 48);
            buttonut.TabIndex = 19;
            buttonut.Text = "Update";
            buttonut.UseVisualStyleBackColor = false;
            buttonut.Click += button2_Click;
            // 
            // buttondl
            // 
            buttondl.BackColor = Color.FromArgb(192, 192, 255);
            buttondl.FlatStyle = FlatStyle.Popup;
            buttondl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondl.Location = new Point(814, 886);
            buttondl.Margin = new Padding(4, 4, 4, 4);
            buttondl.Name = "buttondl";
            buttondl.Size = new Size(118, 48);
            buttondl.TabIndex = 21;
            buttondl.Text = "Delete";
            buttondl.UseVisualStyleBackColor = false;
            buttondl.Click += buttondl_Click;
            // 
            // BView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1210, 982);
            Controls.Add(buttondl);
            Controls.Add(buttonut);
            Controls.Add(label7);
            Controls.Add(textpd);
            Controls.Add(textan);
            Controls.Add(textp);
            Controls.Add(texta);
            Controls.Add(textG);
            Controls.Add(textttl);
            Controls.Add(Available);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textholder);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BView";
            Text = "BView";
            Load += BView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textholder;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Available;
        private TextBox textttl;
        private TextBox textG;
        private TextBox texta;
        private TextBox textp;
        private TextBox textan;
        private DateTimePicker textpd;
        private Label label7;
        private Button buttonut;
        private Button buttondl;
        private Label label6;
    }
}