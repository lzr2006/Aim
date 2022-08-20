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
    public partial class Thanks : Form
    {
        public Thanks()
        {
            InitializeComponent();
        }

        private void panel_Background_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Thanks_Load(object sender, EventArgs e)
        {
            //播放音乐
            MCIPlayer.PlayMusic($"{Application.StartupPath}\\icon\\hlwav.mp3");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_Main.Top -= 2;
        }

        private void label_E_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }
    }
}
