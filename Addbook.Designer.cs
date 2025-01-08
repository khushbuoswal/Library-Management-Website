namespace WinFormsApp6
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            buttonCancel = new Button();
            buttonSubmit = new Button();
            textdate = new DateTimePicker();
            textBookprice = new TextBox();
            textAvailable = new TextBox();
            textGenre = new TextBox();
            textAuthorName = new TextBox();
            texttitle = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(329, 1);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 150);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 54);
            label1.TabIndex = 0;
            label1.Text = "ADD BOOKS";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-9, 1);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 709);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonSubmit);
            panel2.Controls.Add(textdate);
            panel2.Controls.Add(textBookprice);
            panel2.Controls.Add(textAvailable);
            panel2.Controls.Add(textGenre);
            panel2.Controls.Add(textAuthorName);
            panel2.Controls.Add(texttitle);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(329, 149);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 566);
            panel2.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonCancel.Location = new Point(472, 506);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(108, 39);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += button2_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.FlatStyle = FlatStyle.Popup;
            buttonSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonSubmit.Location = new Point(340, 506);
            buttonSubmit.Margin = new Padding(4, 5, 4, 5);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(108, 39);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textdate
            // 
            textdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textdate.Font = new Font("Segoe UI", 9.75F);
            textdate.Location = new Point(294, 291);
            textdate.Margin = new Padding(4, 5, 4, 5);
            textdate.Name = "textdate";
            textdate.Size = new Size(284, 33);
            textdate.TabIndex = 12;
            // 
            // textBookprice
            // 
            textBookprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBookprice.Font = new Font("Segoe UI", 9.75F);
            textBookprice.Location = new Point(294, 434);
            textBookprice.Margin = new Padding(4, 5, 4, 5);
            textBookprice.Name = "textBookprice";
            textBookprice.Size = new Size(284, 33);
            textBookprice.TabIndex = 11;
            // 
            // textAvailable
            // 
            textAvailable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textAvailable.Font = new Font("Segoe UI", 9.75F);
            textAvailable.Location = new Point(294, 361);
            textAvailable.Margin = new Padding(4, 5, 4, 5);
            textAvailable.Name = "textAvailable";
            textAvailable.Size = new Size(284, 33);
            textAvailable.TabIndex = 10;
            // 
            // textGenre
            // 
            textGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textGenre.Font = new Font("Segoe UI", 9.75F);
            textGenre.Location = new Point(294, 219);
            textGenre.Margin = new Padding(4, 5, 4, 5);
            textGenre.Name = "textGenre";
            textGenre.Size = new Size(284, 33);
            textGenre.TabIndex = 8;
            textGenre.TextChanged += textBox3_TextChanged;
            // 
            // textAuthorName
            // 
            textAuthorName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textAuthorName.Font = new Font("Segoe UI", 9.75F);
            textAuthorName.Location = new Point(294, 141);
            textAuthorName.Margin = new Padding(4, 5, 4, 5);
            textAuthorName.Name = "textAuthorName";
            textAuthorName.Size = new Size(284, 33);
            textAuthorName.TabIndex = 7;
            // 
            // texttitle
            // 
            texttitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            texttitle.Font = new Font("Segoe UI", 9.75F);
            texttitle.Location = new Point(294, 66);
            texttitle.Margin = new Padding(4, 5, 4, 5);
            texttitle.Name = "texttitle";
            texttitle.Size = new Size(284, 33);
            texttitle.TabIndex = 6;
            texttitle.TextChanged += textBox1_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 365);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(206, 36);
            label7.TabIndex = 5;
            label7.Text = "Available Copies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 434);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 36);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(184, 36);
            label5.TabIndex = 3;
            label5.Text = "Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 221);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 36);
            label4.TabIndex = 2;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 36);
            label3.TabIndex = 1;
            label3.Text = "Author Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 36);
            label2.TabIndex = 0;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 714);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Addbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbook";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Button buttonCancel;
        private Button buttonSubmit;
        private DateTimePicker textdate;
        private TextBox textBookprice;
        private TextBox textAvailable;
        private TextBox textGenre;
        private TextBox textAuthorName;
        private TextBox texttitle;
    }
}