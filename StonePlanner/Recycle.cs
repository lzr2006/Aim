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
    public partial class Recycle : Form
    {
        public Recycle()
        {
            InitializeComponent();

            LoadCol();
        }

        protected void LoadCol() 
        {
            OleDbConnection conn = new OleDbConnection(
                $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password};"
                ); //Jet OLEDB:Database Password=
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Tasks";
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

        private void Recycle_Load(object sender, EventArgs e)
        {
            //List<Plan> recycleList = Main.recycle_bin;
            //int index = 0;
            //foreach (var item in recycleList)
            //{
            //    dataGridView1.Rows.Add();
            //    dataGridView1.Rows[index].Cells["TaskName"].Value = item.capital;
            //    dataGridView1.Rows[index].Cells["TaskTime"].Value = item.dwSeconds;
            //    dataGridView1.Rows[index].Cells["TaskStatus"].Value = item.status;
            //    dataGridView1.Rows[index].Cells["TaskDifficulty"].Value = item.dwDifficulty;                    ////
            //    if (dataGridView1.Rows[index].Cells["TaskDifficulty"].Value.ToString().Length == 1)             ////
            //    {                                                                                               ////
            //        dataGridView1.Rows[index].Cells["TaskDifficulty"].Value =
            //            $"{dataGridView1.Rows[index].Cells["TaskDifficulty"].Value}.0"
            //            ;//
            //    }
            //    index++;
            //}
        }
    }
}
