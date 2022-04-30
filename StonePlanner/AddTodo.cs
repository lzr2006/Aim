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
    public partial class AddTodo : Form
    {
        public AddTodo()
        {
            InitializeComponent();
        }

        private void AddTodo_Load(object sender, EventArgs e)
        {
            label_T.Text = Main.langInfo[3];
            label_TodoName.Text = Main.langInfo[4];
            label_Numbered.Text = Main.langInfo[5];
            button_New.Text = Main.langInfo[6];
            textBox_Numbered.ReadOnly = true;

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            try
            {
                Main.Sign = 4;
                Main.tName = textBox_Capital.Text;
                Main.tTime = Convert.ToInt32(textBox_Time.Text);
                Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
