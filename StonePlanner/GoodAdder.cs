using System;
using System.Data.OleDb;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class GoodAdder : MetroForm
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
            try
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
                    $"'{textBox_GoodIntro.Text}'," +
                    $"'{textBox_Function.Text}')";
                conn.Open();
                cmd.ExecuteReader();
                GC.Collect();
                Dispose();
            }
            catch (Exception ex){ 
                MessageBox.Show("输入信息有误!","添加失败",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                ErrorCenter.AddError(DateTime.Now.ToString(), "Warning", ex); 
            }
        }

        private void label_Function_Click(object sender, EventArgs e)
        {

        }

        private void GoodAdder_Load(object sender, EventArgs e)
        {

        }

        private void Buton_Cospic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "便携式网络图形|*.png|联合图像专家组|*.jpg|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog.FileName;
                textBox_GoodPicture.Text = fName;
            }
        }
    }
}
