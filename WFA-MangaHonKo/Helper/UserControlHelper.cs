using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MangaHonKo.Helper
{
    class UserControlHelper
    {
        public static void ClearFormControls(Form from)
        {
            throw new NotImplementedException();
        }
        public static void SetUserControl(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }
        public static void SetControlSizePanel(Panel panel, int widthBefore = 0, int widthAfter = 0)
        {
            if(widthBefore != 0)
            {
                if(widthAfter != 0)
                {
                    if (panel.Width == widthBefore)
                    {
                        panel.Width = widthAfter;
                    }
                    else
                    {
                        panel.Width = widthBefore;
                    }
                }
                else
                {
                    panel.Width = widthBefore;
                }
            }
            else
            {
                panel.Width = widthBefore;
            }           
        }

    }
}
