﻿namespace ProjectUnipiGuide
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.GenInfo = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Schools = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenInfo
            // 
            this.GenInfo.BackgroundImage = global::ProjectUnipiGuide.Properties.Resources.Unipic;
            this.GenInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GenInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GenInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenInfo.Location = new System.Drawing.Point(12, 44);
            this.GenInfo.Name = "GenInfo";
            this.GenInfo.Size = new System.Drawing.Size(245, 220);
            this.GenInfo.TabIndex = 0;
            this.GenInfo.Text = "Γενικές Πληροφορίες";
            this.GenInfo.UseVisualStyleBackColor = true;
            this.GenInfo.Click += new System.EventHandler(this.GenInfo_Click);
            // 
            // Services
            // 
            this.Services.BackgroundImage = global::ProjectUnipiGuide.Properties.Resources.Unipic5;
            this.Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Services.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Services.Location = new System.Drawing.Point(505, 55);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(266, 218);
            this.Services.TabIndex = 2;
            this.Services.Text = "Υπηρεσίες";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
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
            this.menuStrip2.TabIndex = 8;
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
            // Schools
            // 
            this.Schools.BackgroundImage = global::ProjectUnipiGuide.Properties.Resources.Unipic3;
            this.Schools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Schools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Schools.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Schools.Location = new System.Drawing.Point(263, 53);
            this.Schools.Name = "Schools";
            this.Schools.Size = new System.Drawing.Size(236, 220);
            this.Schools.TabIndex = 1;
            this.Schools.Text = "Σχολές";
            this.Schools.UseVisualStyleBackColor = true;
            this.Schools.Click += new System.EventHandler(this.Schools_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectUnipiGuide.Properties.Resources.Screenshot_2023_09_02_164008;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Schools);
            this.Controls.Add(this.GenInfo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenInfo;
        private System.Windows.Forms.Button Schools;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}