namespace DobrisaCesaric.View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuthorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookLendingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.lenderToolStripMenuItem,
            this.lendingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "|";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBooksToolStripMenuItem,
            this.viewAuthorsToolStripMenuItem1,
            this.addBookToolStripMenuItem,
            this.addAuthorToolStripMenuItem1});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewBooksToolStripMenuItem.Text = "View books";
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // viewAuthorsToolStripMenuItem1
            // 
            this.viewAuthorsToolStripMenuItem1.Name = "viewAuthorsToolStripMenuItem1";
            this.viewAuthorsToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.viewAuthorsToolStripMenuItem1.Text = "View authors";
            this.viewAuthorsToolStripMenuItem1.Click += new System.EventHandler(this.viewAuthorsToolStripMenuItem1_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addBookToolStripMenuItem.Text = "Add book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // addAuthorToolStripMenuItem1
            // 
            this.addAuthorToolStripMenuItem1.Name = "addAuthorToolStripMenuItem1";
            this.addAuthorToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.addAuthorToolStripMenuItem1.Text = "Add author";
            this.addAuthorToolStripMenuItem1.Click += new System.EventHandler(this.addAuthorToolStripMenuItem1_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLibrarianToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.staffToolStripMenuItem.Text = "Librarians";
            // 
            // addLibrarianToolStripMenuItem
            // 
            this.addLibrarianToolStripMenuItem.Name = "addLibrarianToolStripMenuItem";
            this.addLibrarianToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addLibrarianToolStripMenuItem.Text = "Add librarian";
            this.addLibrarianToolStripMenuItem.Click += new System.EventHandler(this.addLibrarianToolStripMenuItem_Click);
            // 
            // lenderToolStripMenuItem
            // 
            this.lenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLenderToolStripMenuItem});
            this.lenderToolStripMenuItem.Name = "lenderToolStripMenuItem";
            this.lenderToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.lenderToolStripMenuItem.Text = "Lender";
            // 
            // addLenderToolStripMenuItem
            // 
            this.addLenderToolStripMenuItem.Name = "addLenderToolStripMenuItem";
            this.addLenderToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addLenderToolStripMenuItem.Text = "Add lender";
            this.addLenderToolStripMenuItem.Click += new System.EventHandler(this.addLenderToolStripMenuItem_Click);
            // 
            // lendingToolStripMenuItem
            // 
            this.lendingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lendToolStripMenuItem,
            this.bookLendingReportToolStripMenuItem});
            this.lendingToolStripMenuItem.Name = "lendingToolStripMenuItem";
            this.lendingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.lendingToolStripMenuItem.Text = "Lending";
            // 
            // lendToolStripMenuItem
            // 
            this.lendToolStripMenuItem.Name = "lendToolStripMenuItem";
            this.lendToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.lendToolStripMenuItem.Text = "Lend or Return book";
            this.lendToolStripMenuItem.Click += new System.EventHandler(this.lendToolStripMenuItem_Click);
            // 
            // bookLendingReportToolStripMenuItem
            // 
            this.bookLendingReportToolStripMenuItem.Name = "bookLendingReportToolStripMenuItem";
            this.bookLendingReportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.bookLendingReportToolStripMenuItem.Text = "Unreturned books report";
            this.bookLendingReportToolStripMenuItem.Click += new System.EventHandler(this.bookLendingReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 528);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Knjiznica Dobrisa Cesaric";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookLendingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAuthorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

