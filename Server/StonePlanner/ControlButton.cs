using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class ControlButton : UserControl
    {
        protected string text;
        protected Image image;
        protected int signal;

        public ControlButton(string lpText,Image rsImage,int dwSignal)
        {
            InitializeComponent();

            this.text = lpText;
            this.image = rsImage;
            this.signal = dwSignal;
        }


        private void ControlButton_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void ControlButton_Load(object sender, EventArgs e)
        {
            pictureBox_M.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_M.BackgroundImage = image;
            label_F.Text = text;
            this.Top = 82 * (signal - 1);
        }

        private void This_MouseLeave(object sender,EventArgs e) 
        {
            BackColor = Color.WhiteSmoke;
        }

        private void label_F_Click(object sender, EventArgs e)
        {
            if (signal == 1)
            {
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERINFO);
                Main.AddSignal((int) Signals.Signal.SN_ADDSERVERSETTINGS);
                Main.AddSignal((int) Signals.Signal.SN_REMOVETASKSETTINGS);
            }
            else if (signal == 2)
            {
                Main.AddSignal((int) Signals.Signal.SN_ADDSERVERINFO);
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERSETTINGS);
                Main.AddSignal((int) Signals.Signal.SN_REMOVETASKSETTINGS);
            }
            else if (signal == 3)
            {
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERSETTINGS);
                Main.AddSignal((int) Signals.Signal.SN_REMOVESERVERINFO);
                Main.AddSignal((int) Signals.Signal.SN_ADDTASKSETTINGS);
            }
            else if (signal == 4)
            {
                System.Diagnostics.Process.Start("https://lzr2006.github.io/wkgd/shop.html");
            }
            else if (signal == 5)
            {
                MessageBox.Show("正在建设，稍安勿躁!","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
