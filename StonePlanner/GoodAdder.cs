using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class GoodAdder : Form
    {
        public GoodAdder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InnerIDE iDE = new InnerIDE();
            iDE.Show();
        }

        private void AddGood(object sender, EventArgs e)
        {
            //链接数据库
            OleDbConnection conn = new OleDbConnection(
               $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password};"
               ); //Jet OLEDB:Database Password=
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = 
                $"INSERT INTO Goods (GoodPrice,GoodName,GoodPicture,GoodIntro,UseCode) VALUES(" +
                $"{textBox_GoodPrice.Text}," +
                $"'{textBox_GoodName.Text}'," +
                $"'{textBox_GoodPicture.Text}'," +
                $"'{textBox_GoodIntro.Text}',"+
                $"'{textBox_Function.Text}')";
            conn.Open();
            cmd.ExecuteReader();
            GC.Collect();
            Dispose();
        }

        private void label_Function_Click(object sender, EventArgs e)
        {

        }
    }
}
