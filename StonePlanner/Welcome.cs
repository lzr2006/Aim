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

    public partial class Welcome : Form
    {
        int h,w;
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer_AnimationHandler_Tick(object sender, EventArgs e)
        {
            if (h == 1)
            {
                pictureBox_Main.Height += 1;
            }
            else
            {
                pictureBox_Main.Height -= 3;
            }
            if (w == 1)
            {
                pictureBox_Main.Width += 1;
            }
            else
            {
                pictureBox_Main.Width -= 3;
            }
        }
        
        private void Welcome_Load(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox_Main.Height = rd.Next(263, 410);
            pictureBox_Main.Width = rd.Next(387, 500);
            label_C1.Parent = pictureBox_Main;
            label_C2.Parent = pictureBox_Main;
            label_C3.Parent = pictureBox_Main;
            pictureBox_T.Parent = pictureBox_Main;
            pictureBox_D.Width = 0;
        }

        private void pictureBox_D_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox_D.Width >= 400)
            {
                Hide();
                timer_AnimationHandler.Enabled = false;
                Login login = new Login();
                login.ShowDialog();
                Close();
                Hide();
                Opacity = 0;
            }
        }

        private void pictureBox_Main_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox_Main.Height <= 263)
            {
                h = 1;
            }
            else if (pictureBox_Main.Height >= 410)
            {
                h = 0;
            }
            if (pictureBox_Main.Width <= 387)
            {
                w = 1;
            }
            else if (pictureBox_Main.Width >= 500)
            {
                w = 0;
            }
            pictureBox_D.Width += 1;
        }
    }
}
