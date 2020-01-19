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
        public static void SetUserControl(Panel panel, UserControl userControl, string dockStyle)
        {
            panel.Controls.Clear();
           if(dockStyle == UserControlDockStyle.DockStyleFill)
            {
                userControl.Dock = DockStyle.Fill;
            }
            else if(dockStyle == UserControlDockStyle.DockStyleBottom)
            {
                userControl.Dock = DockStyle.Bottom;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleLeft)
            {
                userControl.Dock = DockStyle.Left;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleNone)
            {
                userControl.Dock = DockStyle.None;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleRight)
            {
                userControl.Dock = DockStyle.Right;
            }
            else if (dockStyle == UserControlDockStyle.DockStyleTop)
            {
                userControl.Dock = DockStyle.Top;
            }
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

    public class UserControlDockStyle
    {
        public const string DockStyleNone = "None";
        public const string DockStyleTop = "Top";
        public const string DockStyleBottom = "Bottom";
        public const string DockStyleLeft = "Left";
        public const string DockStyleRight ="Right";
        public const string DockStyleFill = "Fill";
    }
}
