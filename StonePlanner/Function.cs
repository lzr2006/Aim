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
    public partial class Function : UserControl
    {
        string imageAddress = null;
        string caplital = "";
        string __Name__ = "";
        public Function(string lpImageAddress,string lpCapital,string szFunctionName)
        {
            InitializeComponent();

            this.imageAddress = lpImageAddress;
            this.caplital = lpCapital;
            this.__Name__ = szFunctionName;
        }

        private void Function_Load(object sender, EventArgs e)
        {
            pictureBox_M.BackgroundImage = Image.FromFile(imageAddress);
            pictureBox_M.BackgroundImageLayout = ImageLayout.Stretch;
            label_M.Text = caplital;
        }

        private void Function_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

        private void Function_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void Function_Click(object sender, EventArgs e)
        {
            if (__Name__ == "__New__")
            {
                AddTodo at = new AddTodo();
                at.Show();
            }
            else if (__Name__ == "__Export__") 
            {
                Main.Sign = 5;
            }
            else if (__Name__ == "__Recycle__")
            {
                Recycle rc = new Recycle();
                rc.Show();
            }
            else if (__Name__ == "__Infomation__")
            {
                About ab = new About();
                ab.Show();
            }
            else if (__Name__ == "__Console__")
            {
                Console cs = new Console();
                cs.Show();
            }
            else if (__Name__ == "__IDE__")
            {
                //内测
                //TestVersion tv = new TestVersion();
                //tv.Show();
                InnerIDE ide = new InnerIDE();
                ide.Show();
            }
            else if (__Name__ == "__Settings__")
            {
                Settings st = new Settings();
                st.Show();
            }
            else if (__Name__ == "__Shop__")
            {
                Shop so = new Shop();
                so.Show();
            }
        }
    }
}
