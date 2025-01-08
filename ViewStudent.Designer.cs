namespace WinFormsApp6
{
    partial class ViewStudent
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
            label2 = new Label();
            panel3 = new Panel();
            buttondlt = new Button();
            buttonup = new Button();
            label8 = new Label();
            texte = new TextBox();
            textd = new TextBox();
            textc = new TextBox();
            textsi = new TextBox();
            textsn = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGV = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 187);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 38);
            label2.TabIndex = 0;
            label2.Text = "View Student";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(buttondlt);
            panel3.Controls.Add(buttonup);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(texte);
            panel3.Controls.Add(textd);
            panel3.Controls.Add(textc);
            panel3.Controls.Add(textsi);
            panel3.Controls.Add(textsn);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Segoe UI", 12F);
            panel3.Location = new Point(-1, 614);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1211, 355);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // buttondlt
            // 
            buttondlt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttondlt.Location = new Point(905, 245);
            buttondlt.Margin = new Padding(4);
            buttondlt.Name = "buttondlt";
            buttondlt.Size = new Size(118, 48);
            buttondlt.TabIndex = 14;
            buttondlt.Text = "Delete";
            buttondlt.UseVisualStyleBackColor = true;
            buttondlt.Click += buttondlt_Click;
            // 
            // buttonup
            // 
            buttonup.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonup.Location = new Point(770, 245);
            buttonup.Margin = new Padding(4);
            buttonup.Name = "buttonup";
            buttonup.Size = new Size(118, 48);
            buttonup.TabIndex = 13;
            buttonup.Text = "Update";
            buttonup.UseVisualStyleBackColor = true;
            buttonup.Click += buttonup_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(684, 235);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 30);
            label8.TabIndex = 11;
            // 
            // texte
            // 
            texte.Location = new Point(770, 148);
            texte.Margin = new Padding(4);
            texte.Name = "texte";
            texte.Size = new Size(252, 39);
            texte.TabIndex = 10;
            // 
            // textd
            // 
            textd.Location = new Point(770, 45);
            textd.Margin = new Padding(4);
            textd.Name = "textd";
            textd.Size = new Size(252, 39);
            textd.TabIndex = 9;
            // 
            // textc
            // 
            textc.Location = new Point(345, 239);
            textc.Margin = new Padding(4);
            textc.Name = "textc";
            textc.Size = new Size(240, 39);
            textc.TabIndex = 8;
            // 
            // textsi
            // 
            textsi.Location = new Point(345, 145);
            textsi.Margin = new Padding(4);
            textsi.Name = "textsi";
            textsi.Size = new Size(235, 39);
            textsi.TabIndex = 7;
            // 
            // textsn
            // 
            textsn.Location = new Point(345, 51);
            textsn.Margin = new Padding(4);
            textsn.Name = "textsn";
            textsn.Size = new Size(234, 39);
            textsn.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(661, 54);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 3;
            label6.Text = "Degree";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(661, 148);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 4;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(171, 236);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 32);
            label5.TabIndex = 2;
            label5.Text = "Contact";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(171, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 1;
            label4.Text = "Student Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(171, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(476, 192);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 35);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 188);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 4;
            label1.Text = "Student Id";
            // 
            // dataGV
            // 
            dataGV.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGV.Location = new Point(-1, 259);
            dataGV.Margin = new Padding(4);
            dataGV.Name = "dataGV";
            dataGV.RowHeadersWidth = 51;
            dataGV.Size = new Size(1211, 348);
            dataGV.TabIndex = 5;
            dataGV.CellClick += dataGV_CellClick;
            dataGV.CellContentClick += dataGV_CellContentClick;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1210, 1005);
            Controls.Add(dataGV);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ViewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudent";
            Load += ViewStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textsn;
        private TextBox texte;
        private TextBox textd;
        private TextBox textc;
        private TextBox textsi;
        private Button buttondlt;
        private Button buttonup;
        private Label label8;
        private DataGridView dataGV;
    }
}