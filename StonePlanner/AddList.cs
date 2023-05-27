using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class AddList : MetroForm
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
                ErrorCenter.AddError(DataType.ExceptionsLevel.Warning, ex);
                MessageBox.Show($"添加失败，原因是{ex.Message}。","失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void AddList_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }
    }
}
