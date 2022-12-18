using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thanks t = new Thanks();
            t.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
