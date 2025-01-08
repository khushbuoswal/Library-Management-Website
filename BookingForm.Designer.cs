namespace WinFormsApp6
{
    partial class BookingForm
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
            txtdate = new TextBox();
            txtroom = new TextBox();
            txtname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnsave = new Button();
            btncancel = new Button();
            SuspendLayout();
            // 
            // txtdate
            // 
            txtdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtdate.Location = new Point(223, 165);
            txtdate.Margin = new Padding(4, 5, 4, 5);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(365, 31);
            txtdate.TabIndex = 0;
            // 
            // txtroom
            // 
            txtroom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtroom.Location = new Point(223, 250);
            txtroom.Margin = new Padding(4, 5, 4, 5);
            txtroom.Name = "txtroom";
            txtroom.Size = new Size(365, 31);
            txtroom.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtname.Location = new Point(223, 340);
            txtname.Margin = new Padding(4, 5, 4, 5);
            txtname.Name = "txtname";
            txtname.Size = new Size(365, 31);
            txtname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(114, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 32);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(114, 253);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 4;
            label2.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(114, 343);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(521, 485);
            btnsave.Margin = new Padding(4, 5, 4, 5);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(123, 43);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(390, 485);
            btncancel.Margin = new Padding(4, 5, 4, 5);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(123, 43);
            btncancel.TabIndex = 7;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 635);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtname);
            Controls.Add(txtroom);
            Controls.Add(txtdate);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdate;
        private TextBox txtroom;
        private TextBox txtname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnsave;
        private Button btncancel;
    }
}