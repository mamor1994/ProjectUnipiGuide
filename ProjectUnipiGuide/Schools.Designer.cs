﻿namespace ProjectUnipiGuide
{
    partial class Schools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schools));
            this.ManagementStudies = new System.Windows.Forms.Button();
            this.MaritimeStudies = new System.Windows.Forms.Button();
            this.FinanceStudies = new System.Windows.Forms.Button();
            this.ComputerScience = new System.Windows.Forms.Button();
            this.Informatics = new System.Windows.Forms.RadioButton();
            this.DigitalSystems = new System.Windows.Forms.RadioButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagementStudies
            // 
            this.ManagementStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ManagementStudies.Location = new System.Drawing.Point(27, 58);
            this.ManagementStudies.Name = "ManagementStudies";
            this.ManagementStudies.Size = new System.Drawing.Size(155, 77);
            this.ManagementStudies.TabIndex = 0;
            this.ManagementStudies.Text = "ΟΙΚΟΝΟΜΙΚΩΝ, ΕΠΙΧΕΙΡΗΜΑΤΙΚΩΝ ΚΑΙ ΔΙΕΘΝΩΝ ΣΠΟΥΔΩΝ";
            this.ManagementStudies.UseVisualStyleBackColor = true;
            // 
            // MaritimeStudies
            // 
            this.MaritimeStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MaritimeStudies.Location = new System.Drawing.Point(188, 58);
            this.MaritimeStudies.Name = "MaritimeStudies";
            this.MaritimeStudies.Size = new System.Drawing.Size(156, 77);
            this.MaritimeStudies.TabIndex = 1;
            this.MaritimeStudies.Text = "ΝΑΥΤΙΛΙΑΣ ΚΑΙ ΒΙΟΜΗΧΑΝΙΑΣ";
            this.MaritimeStudies.UseVisualStyleBackColor = true;
            // 
            // FinanceStudies
            // 
            this.FinanceStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FinanceStudies.Location = new System.Drawing.Point(350, 58);
            this.FinanceStudies.Name = "FinanceStudies";
            this.FinanceStudies.Size = new System.Drawing.Size(203, 77);
            this.FinanceStudies.TabIndex = 2;
            this.FinanceStudies.Text = "ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΗΣ ΚΑΙ ΣΤΑΤΙΣΤΙΚΗΣ";
            this.FinanceStudies.UseVisualStyleBackColor = true;
            // 
            // ComputerScience
            // 
            this.ComputerScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ComputerScience.Location = new System.Drawing.Point(559, 58);
            this.ComputerScience.Name = "ComputerScience";
            this.ComputerScience.Size = new System.Drawing.Size(155, 77);
            this.ComputerScience.TabIndex = 3;
            this.ComputerScience.Text = "ΤΕΧΝΟΛΟΓΙΩΝ ΠΛΗΡΟΦΟΡΙΚΗΣ ΚΑΙ ΕΠΙΚΟΙΝΩΝΙΩΝ";
            this.ComputerScience.UseVisualStyleBackColor = true;
            this.ComputerScience.Click += new System.EventHandler(this.ComputerScience_Click);
            // 
            // Informatics
            // 
            this.Informatics.AutoSize = true;
            this.Informatics.Location = new System.Drawing.Point(559, 67);
            this.Informatics.Name = "Informatics";
            this.Informatics.Size = new System.Drawing.Size(158, 20);
            this.Informatics.TabIndex = 4;
            this.Informatics.TabStop = true;
            this.Informatics.Text = "Τμήμα Πληροφορικής";
            this.Informatics.UseVisualStyleBackColor = true;
            this.Informatics.Visible = false;
            this.Informatics.CheckedChanged += new System.EventHandler(this.Informatics_CheckedChanged);
            // 
            // DigitalSystems
            // 
            this.DigitalSystems.AutoSize = true;
            this.DigitalSystems.Location = new System.Drawing.Point(559, 93);
            this.DigitalSystems.Name = "DigitalSystems";
            this.DigitalSystems.Size = new System.Drawing.Size(204, 20);
            this.DigitalSystems.TabIndex = 5;
            this.DigitalSystems.TabStop = true;
            this.DigitalSystems.Text = "Τμήμα Ψηφιακών Συστημάτων";
            this.DigitalSystems.UseVisualStyleBackColor = true;
            this.DigitalSystems.Visible = false;
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
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.goBackToolStripMenuItem.Text = "&Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.DigitalSystems);
            this.Controls.Add(this.Informatics);
            this.Controls.Add(this.ComputerScience);
            this.Controls.Add(this.FinanceStudies);
            this.Controls.Add(this.MaritimeStudies);
            this.Controls.Add(this.ManagementStudies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Schools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolsPage";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManagementStudies;
        private System.Windows.Forms.Button MaritimeStudies;
        private System.Windows.Forms.Button FinanceStudies;
        private System.Windows.Forms.Button ComputerScience;
        private System.Windows.Forms.RadioButton Informatics;
        private System.Windows.Forms.RadioButton DigitalSystems;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}