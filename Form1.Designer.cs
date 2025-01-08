namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            adToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addPatronToolStripMenuItem = new ToolStripMenuItem();
            viewPatronDetailsToolStripMenuItem = new ToolStripMenuItem();
            checkOutBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            roomBookingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, checkOutBooksToolStripMenuItem, returnBooksToolStripMenuItem, toolStripMenuItem1, roomBookingToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(71, 24);
            booksToolStripMenuItem.Text = "Books";
            // 
            // adToolStripMenuItem
            // 
            adToolStripMenuItem.Image = (Image)resources.GetObject("adToolStripMenuItem.Image");
            adToolStripMenuItem.Name = "adToolStripMenuItem";
            adToolStripMenuItem.Size = new Size(153, 22);
            adToolStripMenuItem.Text = "Add New Book";
            adToolStripMenuItem.Click += adToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(153, 22);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPatronToolStripMenuItem, viewPatronDetailsToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Patron";
            // 
            // addPatronToolStripMenuItem
            // 
            addPatronToolStripMenuItem.Image = (Image)resources.GetObject("addPatronToolStripMenuItem.Image");
            addPatronToolStripMenuItem.Name = "addPatronToolStripMenuItem";
            addPatronToolStripMenuItem.Size = new Size(184, 26);
            addPatronToolStripMenuItem.Text = "Add Patron";
            addPatronToolStripMenuItem.Click += addPatronToolStripMenuItem_Click;
            // 
            // viewPatronDetailsToolStripMenuItem
            // 
            viewPatronDetailsToolStripMenuItem.Image = (Image)resources.GetObject("viewPatronDetailsToolStripMenuItem.Image");
            viewPatronDetailsToolStripMenuItem.Name = "viewPatronDetailsToolStripMenuItem";
            viewPatronDetailsToolStripMenuItem.Size = new Size(184, 26);
            viewPatronDetailsToolStripMenuItem.Text = "View Patron Details";
            viewPatronDetailsToolStripMenuItem.Click += viewPatronToolStripMenuItem_Click;
            // 
            // checkOutBooksToolStripMenuItem
            // 
            checkOutBooksToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            checkOutBooksToolStripMenuItem.Image = (Image)resources.GetObject("checkOutBooksToolStripMenuItem.Image");
            checkOutBooksToolStripMenuItem.Name = "checkOutBooksToolStripMenuItem";
            checkOutBooksToolStripMenuItem.Size = new Size(112, 24);
            checkOutBooksToolStripMenuItem.Text = "Borrow Books";
            checkOutBooksToolStripMenuItem.Click += checkOutBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(109, 24);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(224, 224, 224);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 24);
            toolStripMenuItem1.Text = "Reporting";
            toolStripMenuItem1.Click += reportingToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(58, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // roomBookingToolStripMenuItem
            // 
            roomBookingToolStripMenuItem.Name = "roomBookingToolStripMenuItem";
            roomBookingToolStripMenuItem.Size = new Size(98, 24);
            roomBookingToolStripMenuItem.Text = "Room Booking";
            roomBookingToolStripMenuItem.Click += roomBookingToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem adToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addPatronToolStripMenuItem;
        private ToolStripMenuItem viewPatronDetailsToolStripMenuItem;
        private ToolStripMenuItem checkOutBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem roomBookingToolStripMenuItem;
    }
}
