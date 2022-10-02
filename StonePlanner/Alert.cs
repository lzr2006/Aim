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
    public partial class Alert : Form
    {
        List<string> tasks;
        public Alert(List<string> tasks)
        {
            InitializeComponent();
            this.tasks = tasks;
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            foreach (var item in tasks)
            {
                listBox_Task.Items.Add(item);
            }
        }
    }
}
