﻿using System;
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
        public MangaHonKoFrom()
        {
            InitializeComponent();
        }
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
            UserControlHelper.SetUserControl(panelBody, userControl: new UCHome(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnCatalogs_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCCatalogs(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnUpdates_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCUpdates(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCFavorites(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panelBody, userControl: new UCSetting(), dockStyle: UserControlDockStyle.DockStyleFill);
        }
        #endregion
        

        

        //UserControlHelper.ClearFormControls(this);
    }
}
