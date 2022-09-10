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
    public partial class Version : UserControl
    {
        string name, text;
        bool download;
        public Version(string szName,string szText,bool bDownloaded)
        {
            InitializeComponent();

            name = szName;
            text = szText;
            download = bDownloaded;
        }

        private void Version_Load(object sender, EventArgs e)
        {
            label_Main.Text = name;
        }
    }
}
