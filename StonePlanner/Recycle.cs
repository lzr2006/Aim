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
    public partial class Recycle : Form
    {
        public Recycle()
        {
            InitializeComponent();
        }

        private void Recycle_Load(object sender, EventArgs e)
        {
            List<Plan> recycleList = Main.recycle_bin;
            int index = 0;
            foreach (var item in recycleList)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["TaskName"].Value = item.capital;
                dataGridView1.Rows[index].Cells["TaskTime"].Value = item.dwSeconds;
                dataGridView1.Rows[index].Cells["TaskStatus"].Value = item.status;
                index++;
            }
        }
    }
}
