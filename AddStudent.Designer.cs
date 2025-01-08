namespace WinFormsApp6
{
    partial class AddStudent
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            buttoncancel = new Button();
            buttonconfirm = new Button();
            textstudentemail = new TextBox();
            textstudentid = new TextBox();
            textstudentdegree = new TextBox();
            textstudentcontact = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textstudentname = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 523);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 3;
            label1.Text = "Add Student";
            // 
            // panel2
            // 
            panel2.Location = new Point(380, 163);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 357);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSize = true;
            panel5.BackColor = Color.FromArgb(192, 192, 255);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(buttoncancel);
            panel5.Controls.Add(buttonconfirm);
            panel5.Controls.Add(textstudentemail);
            panel5.Controls.Add(textstudentid);
            panel5.Controls.Add(textstudentdegree);
            panel5.Controls.Add(textstudentcontact);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textstudentname);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 163);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(977, 517);
            panel5.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 13;
            // 
            // buttoncancel
            // 
            buttoncancel.Anchor = AnchorStyles.None;
            buttoncancel.FlatStyle = FlatStyle.Popup;
            buttoncancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttoncancel.Location = new Point(791, 400);
            buttoncancel.Margin = new Padding(4, 3, 4, 3);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(117, 37);
            buttoncancel.TabIndex = 12;
            buttoncancel.Text = "Cancel";
            buttoncancel.UseVisualStyleBackColor = true;
            buttoncancel.Click += button3_Click;
            // 
            // buttonconfirm
            // 
            buttonconfirm.Anchor = AnchorStyles.None;
            buttonconfirm.FlatStyle = FlatStyle.Popup;
            buttonconfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            buttonconfirm.Location = new Point(650, 400);
            buttonconfirm.Margin = new Padding(4, 3, 4, 3);
            buttonconfirm.Name = "buttonconfirm";
            buttonconfirm.Size = new Size(117, 37);
            buttonconfirm.TabIndex = 11;
            buttonconfirm.Text = "Confirm";
            buttonconfirm.UseVisualStyleBackColor = true;
            buttonconfirm.Click += button2_Click;
            // 
            // textstudentemail
            // 
            textstudentemail.Anchor = AnchorStyles.None;
            textstudentemail.Location = new Point(753, 172);
            textstudentemail.Margin = new Padding(4, 3, 4, 3);
            textstudentemail.Name = "textstudentemail";
            textstudentemail.Size = new Size(210, 31);
            textstudentemail.TabIndex = 9;
            textstudentemail.TextChanged += textBox5_TextChanged;
            // 
            // textstudentid
            // 
            textstudentid.Anchor = AnchorStyles.None;
            textstudentid.Location = new Point(313, 167);
            textstudentid.Margin = new Padding(4, 3, 4, 3);
            textstudentid.Name = "textstudentid";
            textstudentid.Size = new Size(187, 31);
            textstudentid.TabIndex = 8;
            // 
            // textstudentdegree
            // 
            textstudentdegree.Anchor = AnchorStyles.None;
            textstudentdegree.Location = new Point(753, 78);
            textstudentdegree.Margin = new Padding(4, 3, 4, 3);
            textstudentdegree.Name = "textstudentdegree";
            textstudentdegree.Size = new Size(210, 31);
            textstudentdegree.TabIndex = 7;
            textstudentdegree.TextChanged += textBox3_TextChanged;
            // 
            // textstudentcontact
            // 
            textstudentcontact.Anchor = AnchorStyles.None;
            textstudentcontact.Location = new Point(313, 267);
            textstudentcontact.Margin = new Padding(4, 3, 4, 3);
            textstudentcontact.Name = "textstudentcontact";
            textstudentcontact.Size = new Size(187, 31);
            textstudentcontact.TabIndex = 6;
            textstudentcontact.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(581, 78);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 5;
            label6.Text = "Degree";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(581, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 3;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 2;
            label3.Text = "Student Id";
            label3.Click += label3_Click;
            // 
            // textstudentname
            // 
            textstudentname.Anchor = AnchorStyles.None;
            textstudentname.Location = new Point(313, 78);
            textstudentname.Margin = new Padding(4, 3, 4, 3);
            textstudentname.Name = "textstudentname";
            textstudentname.Size = new Size(187, 31);
            textstudentname.TabIndex = 1;
            textstudentname.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label2.Location = new Point(101, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 0;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 685);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textstudentname;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textstudentemail;
        private TextBox textstudentid;
        private TextBox textstudentdegree;
        private TextBox textstudentcontact;
        private Button buttonconfirm;
        private Button buttoncancel;
        private Label label7;
        private Panel panel2;
    }
}