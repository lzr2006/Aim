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
    public partial class ActivationRequired : Form
    {
        public ActivationRequired()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (StonePlanner.License.Code.codes.Contains(textBox_EnterCode.Text))
            {
                MessageBox.Show("激活成功，感谢您的支持，请重启软件。","激活成功",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
