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
        object p = null;
        public Function(string lpImageAddress,string lpCapital,string szFunctionName,object pVoid = null)
        {
            InitializeComponent();

            this.imageAddress = lpImageAddress;
            this.caplital = lpCapital;
            this.__Name__ = szFunctionName;

            if (pVoid != null)
            {
                p = pVoid;
            }
        }
        public Function(string lpCapital, string szListName,int nLineParents, object pVoid = null)
        {
            InitializeComponent();

            this.imageAddress = "";
            this.caplital = lpCapital;
            this.__Name__ = szListName;

            if (nLineParents == 1)
            {
                label_M.Left = 10;
            }
            else
            {
                label_M.Left = 20;
            }
        }

        private void Function_Load(object sender, EventArgs e)
        {
            if (imageAddress != "")
            {
                pictureBox_M.BackgroundImage = Image.FromFile(imageAddress);
            }
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
            if (__Name__[0] == '_')
            {
                if (__Name__ == "__New__")
                {
                    AddTodo at = new AddTodo((AddTodo.PlanAddInvoke)p);
                    at.Show();
                }
                else if (__Name__ == "__Export__")
                {
                    Main.AddSign(5);
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
                else if (__Name__ == "__Online__")                
                {
                    WebService ws = new WebService();
                    ws.Show();
                }
                else if (__Name__ == "__Debugger__")
                {
                    TestTools tt = new TestTools();
                    tt.Show();
                }
                else if (__Name__ == "__Schedule__")
                {
                    Main.AddSign(10);
                }
            }
            else
            {
            }
        }
    }
}
