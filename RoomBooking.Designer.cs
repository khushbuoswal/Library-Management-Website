namespace WinFormsApp6
{
    partial class RoomBooking
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbdate = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 83);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1141, 658);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Monday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Tuesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(537, 53);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 4;
            label4.Text = "Friday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(881, 53);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 5;
            label5.Text = "Saturday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1053, 53);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 6;
            label6.Text = "Sunday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 53);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 7;
            label8.Text = "Wednesday";
            // 
            // button1
            // 
            button1.Location = new Point(1004, 752);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 8;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnnext_Click;
            // 
            // button2
            // 
            button2.Location = new Point(881, 752);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(114, 45);
            button2.TabIndex = 9;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnprevious_Click;
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Location = new Point(519, 15);
            lbdate.Margin = new Padding(4, 0, 4, 0);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(124, 25);
            lbdate.TabIndex = 10;
            lbdate.Text = "MONTH YEAR";
            lbdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoomBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 817);
            Controls.Add(lbdate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RoomBooking";
            Text = "Form2";
            Load += RoomBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button button1;
        private Button button2;
        private Label lbdate;
    }
}