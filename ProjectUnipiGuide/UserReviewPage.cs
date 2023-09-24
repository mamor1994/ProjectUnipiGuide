using ProjectUnipiGuide.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide.DAL
{
    public partial class UserReviewPage : Form
    {
        public UserReviewPage()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLL objbll = new ClassBLL();
            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UserControl1[] listItems = new UserControl1[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new UserControl1();

                            MemoryStream ms = new MemoryStream((byte[])row["Image"]);
                            listItems[i].Icon = new Bitmap(ms);

                            listItems[i].Title = row["Title"].ToString();
                            listItems[i].SubTitle = row["SubTitle"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                            listItems[i].Click += new System.EventHandler(this.UserControl_Click);
                        }
                    }
                }
            }
        }
           
        void UserControl_Click(object sender, EventArgs e)
        {
            UserControl1 obj = (UserControl1)sender;

            pb_icon.Image = obj.Icon;
            lbl_title.Text = obj.Title;
            lbl_subtitle.Text = obj.SubTitle;
            showpanel();
        }

        private void showpanel()
        {
            panel1.Visible = true;
        }
        private void hidepanel()
        { 
            panel1.Visible = false;
        }

        private void UserReviewPage_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
            hidepanel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReviewPage frm = new AddReviewPage();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Εδώ θα βρείτε έναν οδηγό για το Πανεπιστήμιο Πειραιώς ο οποίος δημιουργήθηκε από τον Αντώνη Τζιβάκη και την Μαρία Αμοργιανού.";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntrancePage form = new EntrancePage();
            form.Show();
            this.Hide();
        }
    }
}
