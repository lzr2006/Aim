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
    public partial class ErrorCenter : Form
    {
        public ErrorCenter()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal static void AddError(string time,string errLevel,Exception err) 
        {
            //链接数据库
            string strConn = $" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = {Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password}";
            OleDbConnection myConn = new OleDbConnection(strConn);
            myConn.Open();
            //插入错误
            string ErrInst = $"INSERT INTO Errors (ErrTime,ErrLevel,ErrMessage) VALUES ('{time}','{errLevel}','{err.Message}')";
            OleDbCommand inst = new OleDbCommand(ErrInst, myConn);
            inst.ExecuteNonQuery();
        }
        private void ErrorCenter_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(
      $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password};"
      ); //Jet OLEDB:Database Password=
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Errors";
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
    }
}
