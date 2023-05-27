using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Alert : MetroForm
    {
        List<string> tasks;
        public Alert(List<string> tasks,string alert = "")
        {
            InitializeComponent();
            this.tasks = tasks;
            if (alert == "")
            {
                ErrorCenter.AddError(DataType.ExceptionsLevel.Caution, 
                    new Exceptions.UnknownException("排班日历发生故障，应尽快修复"));
            }
            metroLabel_WorkAlert.Text = $"排班日历：{alert}";
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
