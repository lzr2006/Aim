using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class UserInfo : MetroForm
    {
        //空格数
        int space = 17;
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            if (!Main.activation)
            {
                new Activation().Show();
                label_Username.Text = $"用 户 名：需激活";
                label_Money.Text = $"金 币 数 量：需激活";
                label_LastingC.Text = $"耐力值：需激活";
                label_ExplosiveC.Text = $"爆发值：需激活";
                label_WisdomC.Text = $"智慧值：需激活";
                return;
            }
            //用户基本信息
            label_Username.Text = $"用 户 名：{Login.UserName}";
            label_Money.Text = $"金 币 数 量：{Main.money}";
            //耐力值信息
            var Lasting = LevelGetter(Main.lasting);
            label_LastingC.Text = $"耐力值：{Main.lasting}"+
                Inner.InnerFuncs.MultipleStrings(space- Lasting[0].
                ToString().Length) +$"Lv.{Lasting[0]}";
            label_Lastingleft.Text = Lasting[1].ToString();
            label_Lastingright.Text = Lasting[2].ToString();
            //耐力值进度
            int delta = Convert.ToInt32(label_Lastingright.Text) - Convert.ToInt32(label_Lastingleft.Text);
            int lasting = Main.lasting;
            panel_Lasting.Width = (int) (((double) (lasting - Convert.ToInt32(label_Lastingleft.Text)) / (double) delta) * 184);
            //爆发值信息
            var Explosive = LevelGetter(Main.explosive);
            label_ExplosiveC.Text = $"爆发值：{Main.explosive}" +
                Inner.InnerFuncs.MultipleStrings(space - Explosive[0].
                ToString().Length) + $"Lv.{Explosive[0]}";
            label_Explosiveleft.Text = Explosive[1].ToString();
            label_Explosiveright.Text = Explosive[2].ToString();
            //爆发值进度
            delta = Convert.ToInt32(label_Explosiveright.Text) - Convert.ToInt32(label_Explosiveleft.Text);
            int explosive = Main.explosive;
            panel_Explosive.Width = (int) (((double) (explosive - Convert.ToInt32(label_Explosiveleft.Text)) / (double) delta) * 184);
            //智慧值信息
            var Wisdom = LevelGetter(Main.wisdom);
            label_WisdomC.Text = $"智慧值：{Main.wisdom}" +
               Inner.InnerFuncs.MultipleStrings(space - Wisdom[0].
               ToString().Length) + $"Lv.{Wisdom[0]}";
            label_Wisdomleft.Text = Wisdom[1].ToString();
            label_Wisdomright.Text = Wisdom[2].ToString();
            //智慧值进度
            delta = Convert.ToInt32(label_Wisdomright.Text) - Convert.ToInt32(label_Wisdomleft.Text);
            int wisdom = Main.wisdom;
            panel_Wisdom.Width = (int) (((double) (wisdom - Convert.ToInt32(label_Wisdomleft.Text)) / (double) delta) * 184);
            //综合评分
            double point_User = lasting * 0.05 + wisdom * 0.02 + explosive * 0.01;
            if (point_User > 6)
            {
                point_User = 6d;
            }
            //重构评分读取
            var tasks = SQLConnect.SQLCommandQuery("SELECT * FROM Tasks",ref Main.odcConnection);
            //运用“T10”进行评分
            int i = 0,sum = 0;
            while (tasks.Read())
            {
                sum += Convert.ToInt32(tasks["TaskDiff"]);
                i++;
                if (i == 10) break;
            }
            double point_Plan = sum / i;
            label_Point.Text = $"评 分 值（pp）：{point_User + point_Plan:F2}";
        }

        /// <summary>
        /// 返回级别信息
        /// </summary>
        /// <param name="v">当前值</param>
        /// <returns>【0】= 等级；【1】= 左边界；【2】= 右边界。</returns>
        protected List<int> LevelGetter(int v) 
        {
            int i = 0;
            int j = 0;
            int k = 0;
            for (i = 1; j < v; i++)
            {
                j += 100 * i;
                k += 100 * (i - 1);
            }
            List<int> l = new List<int>();
            l.Add(i-1);
            l.Add(k);
            l.Add(j);
            return l;
        }
    }
}
