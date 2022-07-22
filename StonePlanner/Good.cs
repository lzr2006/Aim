using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Good : UserControl
    {
        internal string GoodName, GoodIntro;
        internal Image GoodPicture;
        internal int GoodPrice,GoodID;
        protected IntPtr lev;

        private void btn_GoodPrice_Click(object sender, EventArgs e)
        {
            if (lev == new IntPtr(1))
            {
                //购买模式
                if (Main.money > GoodPrice)
                {
                    //减少金钱
                    Main.MoneyUpdate(-GoodPrice);
                    //执行
                    var reader = SQLConnect.SQLCommandQuery($"SELECT UseCode FROM Goods WHERE GoodName = '{GoodName}'");
                    reader.Read();
                    string code = reader.GetValue(0).ToString();
                    //存储并解析
                    string path = $@"{Application.StartupPath}\temp\cFile{new Random().Next(100000, 999999)}.txt";
                    StreamWriter sw = new StreamWriter(path);
                    sw.Write(code);
                    sw.Close();
                    MessageBox.Show(InnerIDE.SyntaxParser_Outer($"COMPILE {path}"));
                }
                else
                {
                    MessageBox.Show($"您的金钱不够，还缺{GoodPrice - Main.money}。");
                }
            }
            else
            {
                //使用模式

            }
        }

        public Good(string GoodName,string GoodIntro,Image GoodPicture,int GoodPrice,int ID,IntPtr i)
        {
            InitializeComponent();

            this.GoodName = GoodName;
            this.GoodIntro = GoodIntro;
            this.GoodPicture = GoodPicture;
            this.GoodPrice = GoodPrice;
            this.GoodID = ID;
            this.lev = i;

            GC.Collect();
        }

        private void Good_Load(object sender, EventArgs e)
        {
            if (lev == new IntPtr(1))
            {
                //购买模式
                label_GoodIntro.Text = GoodIntro;
                label_GoodName.Text = GoodName;
                pbox_GoodPicture.BackgroundImage = GoodPicture;
                btn_GoodPrice.Text = $"购买（&P& {GoodPrice.ToString()}）";

                string lv = "";
                int i = 1;
                foreach (var item in label_GoodIntro.Text)
                {
                    lv += item;
                    if (i % 10 == 0)
                    {
                        lv += "\n";
                    }
                    i++;
                }
                GC.Collect();
                label_GoodIntro.Text = lv;
            }
            else
            {
                //使用模式
                btn_GoodPrice.Text = "使用";
            }
        }
    }
}
