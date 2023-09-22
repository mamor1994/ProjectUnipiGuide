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
            this.SuspendLayout();
            // 
            // btnPlOverviewPage
            // 
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
            this.btnPlVideoPage.Location = new System.Drawing.Point(345, 352);
            this.btnPlVideoPage.Name = "btnPlVideoPage";
            this.btnPlVideoPage.Size = new System.Drawing.Size(225, 77);
            this.btnPlVideoPage.TabIndex = 3;
            this.btnPlVideoPage.Text = "Βίντεο Τμήματος Πληροφορικής";
            this.btnPlVideoPage.UseVisualStyleBackColor = true;
            this.btnPlVideoPage.Click += new System.EventHandler(this.btnPlVideoPage_Click);
            // 
            // PlMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlVideoPage);
            this.Controls.Add(this.btnPlPage);
            this.Controls.Add(this.btnPlProfessorsPage);
            this.Controls.Add(this.btnPlOverviewPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlMenuPage";
            this.Text = "PlMenuPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlOverviewPage;
        private System.Windows.Forms.Button btnPlProfessorsPage;
        private System.Windows.Forms.Button btnPlPage;
        private System.Windows.Forms.Button btnPlVideoPage;
    }
}