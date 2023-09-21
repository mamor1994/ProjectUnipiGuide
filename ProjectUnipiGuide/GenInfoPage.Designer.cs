namespace ProjectUnipiGuide
{
    partial class GenInfoPage
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
            this.History = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.History.Location = new System.Drawing.Point(129, 57);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(108, 46);
            this.History.TabIndex = 0;
            this.History.Text = "Ιστορία";
            this.History.UseVisualStyleBackColor = true;
            // 
            // GenInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.History);
            this.Name = "GenInfoPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenInfoPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button History;
    }
}