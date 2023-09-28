
namespace ProjectUnipiGuide
{
    partial class KathigitesPlPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KathigitesPlPage));
            this.lbKathightes = new System.Windows.Forms.Label();
            this.listViewPeople = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTmhma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrafeio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoadAnaplhrwtes = new System.Windows.Forms.Button();
            this.btnEpikouroi = new System.Windows.Forms.Button();
            this.lbMelhDep = new System.Windows.Forms.Label();
            this.btnKathigites = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOmotimoi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKathightes
            // 
            this.lbKathightes.AutoSize = true;
            this.lbKathightes.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbKathightes.Location = new System.Drawing.Point(13, 97);
            this.lbKathightes.Name = "lbKathightes";
            this.lbKathightes.Size = new System.Drawing.Size(0, 27);
            this.lbKathightes.TabIndex = 1;
            // 
            // listViewPeople
            // 
            this.listViewPeople.BackColor = System.Drawing.Color.LightGray;
            this.listViewPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chTmhma,
            this.chGrafeio,
            this.chPhone,
            this.chEmail});
            this.listViewPeople.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPeople.GridLines = true;
            this.listViewPeople.HideSelection = false;
            this.listViewPeople.Location = new System.Drawing.Point(12, 147);
            this.listViewPeople.Name = "listViewPeople";
            this.listViewPeople.Size = new System.Drawing.Size(1129, 323);
            this.listViewPeople.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPeople.TabIndex = 3;
            this.listViewPeople.UseCompatibleStateImageBehavior = false;
            this.listViewPeople.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Ονοματεπώνυμο";
            this.chName.Width = 241;
            // 
            // chTmhma
            // 
            this.chTmhma.Text = "Τμήμα";
            this.chTmhma.Width = 169;
            // 
            // chGrafeio
            // 
            this.chGrafeio.Text = "Γραφείο";
            this.chGrafeio.Width = 139;
            // 
            // chPhone
            // 
            this.chPhone.Text = "Τηλέφωνο";
            this.chPhone.Width = 205;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 294;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Red;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnExport.Location = new System.Drawing.Point(506, 586);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 61);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoadAnaplhrwtes
            // 
            this.btnLoadAnaplhrwtes.BackColor = System.Drawing.Color.Blue;
            this.btnLoadAnaplhrwtes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAnaplhrwtes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadAnaplhrwtes.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnLoadAnaplhrwtes.Location = new System.Drawing.Point(67, 512);
            this.btnLoadAnaplhrwtes.Name = "btnLoadAnaplhrwtes";
            this.btnLoadAnaplhrwtes.Size = new System.Drawing.Size(296, 50);
            this.btnLoadAnaplhrwtes.TabIndex = 5;
            this.btnLoadAnaplhrwtes.Text = "Load Αναπληρωτές Καθηγητές";
            this.btnLoadAnaplhrwtes.UseVisualStyleBackColor = false;
            this.btnLoadAnaplhrwtes.Click += new System.EventHandler(this.btnLoadAnaplhrwtes_Click);
            // 
            // btnEpikouroi
            // 
            this.btnEpikouroi.BackColor = System.Drawing.Color.Blue;
            this.btnEpikouroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEpikouroi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEpikouroi.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnEpikouroi.Location = new System.Drawing.Point(424, 512);
            this.btnEpikouroi.Name = "btnEpikouroi";
            this.btnEpikouroi.Size = new System.Drawing.Size(296, 50);
            this.btnEpikouroi.TabIndex = 6;
            this.btnEpikouroi.Text = "Load Επίκουροι Καθηγητές";
            this.btnEpikouroi.UseVisualStyleBackColor = false;
            this.btnEpikouroi.Click += new System.EventHandler(this.btnEpikouroi_Click);
            // 
            // lbMelhDep
            // 
            this.lbMelhDep.AutoSize = true;
            this.lbMelhDep.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbMelhDep.Location = new System.Drawing.Point(11, 46);
            this.lbMelhDep.Name = "lbMelhDep";
            this.lbMelhDep.Size = new System.Drawing.Size(168, 37);
            this.lbMelhDep.TabIndex = 7;
            this.lbMelhDep.Text = "ΜΕΛΗ ΔΕΠ";
            // 
            // btnKathigites
            // 
            this.btnKathigites.BackColor = System.Drawing.Color.Blue;
            this.btnKathigites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKathigites.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKathigites.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnKathigites.Location = new System.Drawing.Point(771, 512);
            this.btnKathigites.Name = "btnKathigites";
            this.btnKathigites.Size = new System.Drawing.Size(296, 50);
            this.btnKathigites.TabIndex = 8;
            this.btnKathigites.Text = "Load Καθηγητές";
            this.btnKathigites.UseVisualStyleBackColor = false;
            this.btnKathigites.Click += new System.EventHandler(this.btnKathigites_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1155, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
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
            // btnOmotimoi
            // 
            this.btnOmotimoi.BackColor = System.Drawing.Color.Blue;
            this.btnOmotimoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOmotimoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOmotimoi.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnOmotimoi.Location = new System.Drawing.Point(424, 512);
            this.btnOmotimoi.Name = "btnOmotimoi";
            this.btnOmotimoi.Size = new System.Drawing.Size(296, 50);
            this.btnOmotimoi.TabIndex = 10;
            this.btnOmotimoi.Text = "Load Ομότιμοι Καθηγητές";
            this.btnOmotimoi.UseVisualStyleBackColor = false;
            this.btnOmotimoi.Visible = false;
            this.btnOmotimoi.Click += new System.EventHandler(this.btnOmotimoi_Click);
            // 
            // KathigitesPlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 659);
            this.Controls.Add(this.btnOmotimoi);
            this.Controls.Add(this.btnKathigites);
            this.Controls.Add(this.lbMelhDep);
            this.Controls.Add(this.btnEpikouroi);
            this.Controls.Add(this.btnLoadAnaplhrwtes);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.listViewPeople);
            this.Controls.Add(this.lbKathightes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KathigitesPlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KathigitesPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KathigitesPlPage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKathightes;
        private System.Windows.Forms.ListView listViewPeople;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chTmhma;
        private System.Windows.Forms.ColumnHeader chGrafeio;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnLoadAnaplhrwtes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.Button btnEpikouroi;
        public System.Windows.Forms.Button btnKathigites;
        public System.Windows.Forms.Label lbMelhDep;
        public System.Windows.Forms.Button btnOmotimoi;
    }
}