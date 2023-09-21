namespace ProjectUnipiGuide
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
            this.GenInfo = new System.Windows.Forms.Button();
            this.Schools = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenInfo
            // 
            this.GenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GenInfo.Location = new System.Drawing.Point(37, 62);
            this.GenInfo.Name = "GenInfo";
            this.GenInfo.Size = new System.Drawing.Size(195, 53);
            this.GenInfo.TabIndex = 0;
            this.GenInfo.Text = "Γενικές Πληροφορίες";
            this.GenInfo.UseVisualStyleBackColor = true;
            // 
            // Schools
            // 
            this.Schools.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Schools.Location = new System.Drawing.Point(250, 62);
            this.Schools.Name = "Schools";
            this.Schools.Size = new System.Drawing.Size(183, 52);
            this.Schools.TabIndex = 1;
            this.Schools.Text = "Σχολές";
            this.Schools.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Services.Location = new System.Drawing.Point(461, 62);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(141, 51);
            this.Services.TabIndex = 2;
            this.Services.Text = "Υπηρεσίες";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Schools);
            this.Controls.Add(this.GenInfo);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenInfo;
        private System.Windows.Forms.Button Schools;
        private System.Windows.Forms.Button Services;
    }
}