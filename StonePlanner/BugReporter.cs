using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class BugReporter : MetroForm
    {
        string info;
        public BugReporter(string pInfo)
        {
            InitializeComponent();

            this.info = pInfo;
        }

        private void BugReporter_Load(object sender, EventArgs e)
        {
            metroTextBox1.Multiline = true;
            metroTextBox1.Text = info;
        }
    }
}
