using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Importer : Form
    {
        public Importer()
        {
            InitializeComponent();
        }

        private void button_Choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择预设包";
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "预设数据库|*.mdb";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Address.Text = openFileDialog.FileName;
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            if (textBox_Password.Text != "")
            {
                conn = new OleDbConnection(
                $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={textBox_Address.Text};" +
                $"Jet OLEDB:Database Password={textBox_Password.Text};"
                );
            }
            else
            {
                conn = new OleDbConnection(
                $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={textBox_Address.Text};"
                );
            }
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Goods";
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            if (dr.HasRows)
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
                dt.Rows.Clear();
            }
            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    row[i] = dr[i];
                }
                dt.Rows.Add(row);
            }
            cmd.Dispose();
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void Importer_Load(object sender, EventArgs e)
        {

        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            //扫描数据
            List<string> k = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j < dataGridView1.Columns.Count - 1)
                    {
                        k.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        SQLConnect.SQLCommandExecution("INSERT INTO Goods(GoodPrice,GoodName,GoodPicture,GoodIntro,UseCode)" +
                            $"VALUES({k[0]},'{k[1]}','{k[2]}','{k[3]}','{k[4]}')", ref Main.odcConnection);
                    }
                }
                k.Clear();
                GC.Collect();
            }
            MessageBox.Show("倒入完成");
        }
    }
}
