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
            this.ManagementStudies = new System.Windows.Forms.Button();
            this.MaritimeStudies = new System.Windows.Forms.Button();
            this.FinanceStudies = new System.Windows.Forms.Button();
            this.ComputerScience = new System.Windows.Forms.Button();
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
            // 
            // Schools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComputerScience);
            this.Controls.Add(this.FinanceStudies);
            this.Controls.Add(this.MaritimeStudies);
            this.Controls.Add(this.ManagementStudies);
            this.Name = "Schools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolsPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManagementStudies;
        private System.Windows.Forms.Button MaritimeStudies;
        private System.Windows.Forms.Button FinanceStudies;
        private System.Windows.Forms.Button ComputerScience;
    }
}