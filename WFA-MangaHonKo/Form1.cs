using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MangaHonKo
{
    public partial class MangaHonKoFrom : Form
    {
        public MangaHonKoFrom()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.selected = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 190)
            {
                panelLeft.Width = 60;
            }
            else
            {
                panelLeft.Width = 190;
            }
        }

        private void btnFromClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFromMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnFromMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
