
namespace ProjectUnipiGuide
{
    partial class EventPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventPage));
            this.txdate = new System.Windows.Forms.TextBox();
            this.txevent = new System.Windows.Forms.TextBox();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbevent = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.HideSelection = false;
            this.txdate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txdate.Location = new System.Drawing.Point(45, 69);
            this.txdate.Name = "txdate";
            this.txdate.ReadOnly = true;
            this.txdate.Size = new System.Drawing.Size(414, 40);
            this.txdate.TabIndex = 0;
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(45, 172);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(414, 40);
            this.txevent.TabIndex = 1;
            this.txevent.Click += new System.EventHandler(this.EventPage_Load);
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.Location = new System.Drawing.Point(42, 26);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(57, 40);
            this.lbdate.TabIndex = 2;
            this.lbdate.Text = "Date";
            // 
            // lbevent
            // 
            this.lbevent.AutoSize = true;
            this.lbevent.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbevent.Location = new System.Drawing.Point(41, 124);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(72, 43);
            this.lbevent.TabIndex = 3;
            this.lbevent.Text = "Event";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(342, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 311);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "EventPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventPage";
            this.Load += new System.EventHandler(this.EventPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbevent;
        private System.Windows.Forms.Button btnSave;
    }
}