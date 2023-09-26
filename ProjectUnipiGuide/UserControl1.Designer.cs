namespace ProjectUnipiGuide.DAL
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_icon
            // 
            this.pb_icon.BackColor = System.Drawing.Color.Orange;
            this.pb_icon.Location = new System.Drawing.Point(15, 15);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(71, 55);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 88);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(3, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 1);
            this.panel2.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(108, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(32, 24);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Title";
            // 
            // lbl_subtitle
            // 
            this.lbl_subtitle.AutoSize = true;
            this.lbl_subtitle.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle.Location = new System.Drawing.Point(108, 46);
            this.lbl_subtitle.Name = "lbl_subtitle";
            this.lbl_subtitle.Size = new System.Drawing.Size(47, 24);
            this.lbl_subtitle.TabIndex = 3;
            this.lbl_subtitle.Text = "Subtitle";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_subtitle);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(353, 84);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Panel panel2;
    }
}
