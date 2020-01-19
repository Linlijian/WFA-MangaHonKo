using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_MangaHonKo.Helper;

namespace WFA_MangaHonKo
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            UserControlHelper.SetUserControl(panel1, userControl: new UserControl1());
            UserControlHelper.SetUserControl(panel2, userControl: new UserControl1());
            UserControlHelper.SetUserControl(panel3, userControl: new UserControl1());
            UserControlHelper.SetUserControl(panel4, userControl: new UserControl1());
        }
    }
}
