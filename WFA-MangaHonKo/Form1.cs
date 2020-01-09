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

       
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    if (panelSearch.Width == 261)
        //    {
        //        panelSearch.Width = 49;
        //    }
        //    else
        //    {
        //        panelSearch.Width = 261;
        //    }
        //}
    }
}
