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
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                SQLConnect.SQLCommandExecution($"INSERT INTO Lists (ListName) VALUES('{textBox_Listname.Text}')",ref Main.odcConnection);
                Close();   
            }
            catch(Exception ex) 
            {
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex);
                MessageBox.Show($"添加失败，原因是{ex.Message}。","失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
