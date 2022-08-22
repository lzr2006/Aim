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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        protected List<Good> goodList;
        protected int page = 1,maxPage = 1;
        internal static int PWMS_ACCOUNT;
        private void Shop_Load(object sender, EventArgs e)
        {
            //连接数据库 获取商品
            OleDbConnection conn = new OleDbConnection(
               $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password};"
               ); //Jet OLEDB:Database Password=
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
            dataGridView1.Visible = false;

            //展示商品
            goodList = new List<Good>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                try
                {
                    Good good = new Good
                        (
                          dataGridView1.Rows[i].Cells[2].Value.ToString(),
                          dataGridView1.Rows[i].Cells[4].Value.ToString(),
                          Image.FromFile(dataGridView1.Rows[i].Cells[3].Value.ToString()),
                          Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                          Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value),
                          new IntPtr(1) //购买模式
                        );
                    goodList.Add(good);
                }
                catch (Exception ex)
                {
                    Main.exceptionsList.Add(ex);
                    MessageBox.Show("在商品中出现了一个错误，导致读取终止，具体信息请详见错误中心。","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ErrorCenter.AddError(DateTime.Now.ToString(),"Error",ex);
                    ErrorCenter ec = new ErrorCenter();
                }
            }
            maxPage = goodList.Count / 6 + 1;
            PWMS_ACCOUNT = goodList.Count;
            label_Main.Text = $"第{page}页，共{maxPage}页";
            goodShower(page);
        }

        internal void goodShower(int page) 
        {
            try 
            {
                int p = page - 1;
                goodList[0 + 6 * p].Location = new Point(10, 20);
                panel_Main.Controls.Add(goodList[0 + 6 * p]);
                goodList[1 + 6 * p].Location = new Point(310, 20);
                panel_Main.Controls.Add(goodList[1 + 6 * p]);
                goodList[2 + 6 * p].Location = new Point(610, 20);
                panel_Main.Controls.Add(goodList[2 + 6 * p]);
                goodList[3 + 6 * p].Location = new Point(10, 160);
                panel_Main.Controls.Add(goodList[3 + 6 * p]);
                goodList[4 + 6 * p].Location = new Point(310, 160);
                panel_Main.Controls.Add(goodList[4 + 6 * p]);
                goodList[5 + 6 * p].Location = new Point(610, 160);
                panel_Main.Controls.Add(goodList[5 + 6 * p]);
            }
            catch { }
        }

        private void btn_tRight_Click(object sender, EventArgs e)
        {
            if (page == maxPage)
            {
                MessageBox.Show("已经是最后一页！");
            }
            else
            {
                panel_Main.Controls.Clear();
                page++;
                goodShower(page);
                label_Main.Text = $"第{page}页，共{maxPage}页";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoodAdder ga = new GoodAdder();
            ga.Show();
        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tLeft_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                MessageBox.Show("已经是第一页！");
            }
            else
            {
                panel_Main.Controls.Clear();
                page--;
                goodShower(page);
                label_Main.Text = $"第{page}页，共{maxPage}页";
            }
        }
    }
}
