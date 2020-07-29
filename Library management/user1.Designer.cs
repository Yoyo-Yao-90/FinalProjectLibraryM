namespace Library_management
{
    partial class user1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndBorrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myBookBorrowAndReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.findAndBorrowBookToolStripMenuItem,
            this.myBookBorrowAndReturnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.contactAdminToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // contactAdminToolStripMenuItem
            // 
            this.contactAdminToolStripMenuItem.Name = "contactAdminToolStripMenuItem";
            this.contactAdminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactAdminToolStripMenuItem.Text = "Contact Admin";
            // 
            // findAndBorrowBookToolStripMenuItem
            // 
            this.findAndBorrowBookToolStripMenuItem.Name = "findAndBorrowBookToolStripMenuItem";
            this.findAndBorrowBookToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.findAndBorrowBookToolStripMenuItem.Text = "Find and Borrow Book";
            this.findAndBorrowBookToolStripMenuItem.Click += new System.EventHandler(this.findAndBorrowBookToolStripMenuItem_Click);
            // 
            // myBookBorrowAndReturnToolStripMenuItem
            // 
            this.myBookBorrowAndReturnToolStripMenuItem.Name = "myBookBorrowAndReturnToolStripMenuItem";
            this.myBookBorrowAndReturnToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.myBookBorrowAndReturnToolStripMenuItem.Text = "My Book Borrow and Return";
            this.myBookBorrowAndReturnToolStripMenuItem.Click += new System.EventHandler(this.myBookBorrowAndReturnToolStripMenuItem_Click);
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user1";
            this.Text = "User Homepage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndBorrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myBookBorrowAndReturnToolStripMenuItem;
    }
}