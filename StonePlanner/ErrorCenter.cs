using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class ErrorCenter : MetroForm
    {
        public ErrorCenter()
        {
            InitializeComponent();

            if (!Program.EnableErrorCenter)
            {
                Text = "错误中心（未启用记录）";
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal static void AddError(DataType.ExceptionsLevel errLevel,Exception err) 
        {
            if (!Program.EnableErrorCenter)
            {
                return;
            }
            string levelString = errLevel switch
            {
                DataType.ExceptionsLevel.Infomation => "Infomation",
                DataType.ExceptionsLevel.Caution => "Caution",
                DataType.ExceptionsLevel.Warning => "Warning",
                DataType.ExceptionsLevel.Error => "Error",
                _ => throw new Exception("不存在这样的类型")
            };
            string trace = err.StackTrace;
            string[] kb = trace.Split(' ');

            string sourceString = $"Aim";
            SQLConnect.SQLCommandExecution($"INSERT INTO Errors (ErrTime,ErrLevel,ErrMessage,Source)" +
                $" VALUES ('{DateTime.Now}','{levelString}','{err.Message}','{sourceString}')",ref Main.odcConnection);
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
