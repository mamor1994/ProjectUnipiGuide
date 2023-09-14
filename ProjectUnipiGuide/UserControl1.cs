using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide.DAL
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _title;
        private string _subtitle;

        [Category("Custom Props")]

        public Image Icon { get { return _icon; } set { _icon = value; pb_icon.Image = value; } }

        [Category("Custom Props")]

        public string Title { get { return _title; } set { _title = value; lbl_title.Text = value; } }

        [Category("Custom Props")]

        public string SubTitle { get { return _subtitle; } set { _subtitle = value; lbl_subtitle.Text = value; } }


        private void ucRequest_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void ucRequest_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

    }
}
