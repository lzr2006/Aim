using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Alert : MetroForm
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
