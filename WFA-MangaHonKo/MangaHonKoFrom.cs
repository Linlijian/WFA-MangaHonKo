using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangaLibrary;
using WFA_MangaHonKo.Helper;

namespace WFA_MangaHonKo
{
    public partial class MangaHonKoFrom : Form
    {
        #region Initial
        public MangaHonKoFrom()
        {
            InitializeComponent();
        }
        private void MangaHonKoFrom_Load(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCHome());
        }
        #endregion

        #region from button        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetControlSizePanel(panelLeft, 190, 60);
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCHome());
        }
        private void btnCatalogs_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCCatalogs());
        }
        private void btnUpdates_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCUpdates());
        }
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCFavorites());
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCSetting());
        }
        #endregion




        //UserControlHelper.ClearFormControls(this);
    }
}
