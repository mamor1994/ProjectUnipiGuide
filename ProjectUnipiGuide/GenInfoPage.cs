﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUnipiGuide
{
    public partial class GenInfoPage : Form
    {
        public GenInfoPage()
        {
            InitializeComponent();
        }

        private void History_Click(object sender, EventArgs e)
        {
            UniHistoryPage newform = new UniHistoryPage();
            newform.Show();
            this.Hide();
        }
    }
}
