using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectUnipiGuide.BLL;

namespace ProjectUnipiGuide
{
    public partial class AddReviewPage : Form
    {
        public AddReviewPage()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string emojiDirectory = System.IO.Path.Combine(appDirectory, "emoji");

            OpenFileDialog opendlg = new OpenFileDialog();
            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pb_image.Image = image;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();
            if (objbll.SaveItems(pb_image.Image, txt_title.Text, txt_subtitle.Text))
            {
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }
    }
}
