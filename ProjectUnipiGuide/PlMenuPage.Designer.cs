namespace ProjectUnipiGuide
{
    partial class PlMenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlMenuPage));
            this.btnPlOverviewPage = new System.Windows.Forms.Button();
            this.btnPlProfessorsPage = new System.Windows.Forms.Button();
            this.btnPlPage = new System.Windows.Forms.Button();
            this.btnPlVideoPage = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlOverviewPage
            // 
            this.btnPlOverviewPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlOverviewPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlOverviewPage.Location = new System.Drawing.Point(345, 76);
            this.btnPlOverviewPage.Name = "btnPlOverviewPage";
            this.btnPlOverviewPage.Size = new System.Drawing.Size(225, 58);
            this.btnPlOverviewPage.TabIndex = 0;
            this.btnPlOverviewPage.Text = "Overview";
            this.btnPlOverviewPage.UseVisualStyleBackColor = true;
            this.btnPlOverviewPage.Click += new System.EventHandler(this.btnPlOverviewPage_Click);
            // 
            // btnPlProfessorsPage
            // 
            this.btnPlProfessorsPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlProfessorsPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlProfessorsPage.Location = new System.Drawing.Point(345, 157);
            this.btnPlProfessorsPage.Name = "btnPlProfessorsPage";
            this.btnPlProfessorsPage.Size = new System.Drawing.Size(225, 64);
            this.btnPlProfessorsPage.TabIndex = 1;
            this.btnPlProfessorsPage.Text = "Professors";
            this.btnPlProfessorsPage.UseVisualStyleBackColor = true;
            this.btnPlProfessorsPage.Click += new System.EventHandler(this.btnPlProfessorsPage_Click);
            // 
            // btnPlPage
            // 
            this.btnPlPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlPage.Location = new System.Drawing.Point(345, 250);
            this.btnPlPage.Name = "btnPlPage";
            this.btnPlPage.Size = new System.Drawing.Size(225, 69);
            this.btnPlPage.TabIndex = 2;
            this.btnPlPage.Text = "Σελίδα Τμήματος Πληροφορικής";
            this.btnPlPage.UseVisualStyleBackColor = true;
            this.btnPlPage.Click += new System.EventHandler(this.btnPlPage_Click);
            // 
            // btnPlVideoPage
            // 
            this.btnPlVideoPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlVideoPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlVideoPage.Location = new System.Drawing.Point(345, 352);
            this.btnPlVideoPage.Name = "btnPlVideoPage";
            this.btnPlVideoPage.Size = new System.Drawing.Size(225, 77);
            this.btnPlVideoPage.TabIndex = 3;
            this.btnPlVideoPage.Text = "Βίντεο Τμήματος Πληροφορικής";
            this.btnPlVideoPage.UseVisualStyleBackColor = true;
            this.btnPlVideoPage.Click += new System.EventHandler(this.btnPlVideoPage_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goBackToolStripMenuItem.Image")));
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.goBackToolStripMenuItem.Text = "&Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PlMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnPlVideoPage);
            this.Controls.Add(this.btnPlPage);
            this.Controls.Add(this.btnPlProfessorsPage);
            this.Controls.Add(this.btnPlOverviewPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlMenuPage";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlOverviewPage;
        private System.Windows.Forms.Button btnPlProfessorsPage;
        private System.Windows.Forms.Button btnPlPage;
        private System.Windows.Forms.Button btnPlVideoPage;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}