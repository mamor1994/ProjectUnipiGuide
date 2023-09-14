﻿namespace ProjectUnipiGuide
{
    partial class AddReviewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReviewPage));
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_subtitle = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_subtitle = new System.Windows.Forms.TextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(264, 247);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(137, 44);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "Upload Image";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(299, 446);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Location = new System.Drawing.Point(64, 340);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(35, 17);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "Title";
            // 
            // lb_subtitle
            // 
            this.lb_subtitle.AutoSize = true;
            this.lb_subtitle.Location = new System.Drawing.Point(64, 390);
            this.lb_subtitle.Name = "lb_subtitle";
            this.lb_subtitle.Size = new System.Drawing.Size(60, 17);
            this.lb_subtitle.TabIndex = 4;
            this.lb_subtitle.Text = "SubTitle";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(217, 312);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(245, 44);
            this.txt_title.TabIndex = 5;
            // 
            // txt_subtitle
            // 
            this.txt_subtitle.Location = new System.Drawing.Point(217, 373);
            this.txt_subtitle.Multiline = true;
            this.txt_subtitle.Name = "txt_subtitle";
            this.txt_subtitle.Size = new System.Drawing.Size(245, 42);
            this.txt_subtitle.TabIndex = 6;
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.SystemColors.Window;
            this.pb_image.Location = new System.Drawing.Point(217, 21);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(245, 197);
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            // 
            // AddReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(633, 500);
            this.Controls.Add(this.txt_subtitle);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lb_subtitle);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pb_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddReviewPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReviewPage";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_subtitle;
    }
}