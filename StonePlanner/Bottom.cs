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
    public partial class Bottom : UserControl
    {
        private string str;
        public Bottom(string str)
        {
            InitializeComponent();

            this.str = str;
            Name = "buttom";
        }

        private void Bottom_Load(object sender, EventArgs e)
        {
            label_B.Text = str;
        }

        private void label_B_Click(object sender, EventArgs e)
        {

        }
    }
}
