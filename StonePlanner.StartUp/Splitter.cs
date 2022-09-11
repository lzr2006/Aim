using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner.StartUp
{
    public partial class Splitter : UserControl
    {
        string version;
        public Splitter(string lpVersion)
        {
            InitializeComponent();

            version = lpVersion;
            label_Version.Text = version;
        }

        private void Splitter_Load(object sender, EventArgs e)
        {

        }

        private void panel_R_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
