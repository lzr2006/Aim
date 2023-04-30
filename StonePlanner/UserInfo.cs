using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StonePlanner
{
    public partial class UserInfo : MetroForm
    {
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
            label_LastingC.Text = $"耐力值：{Main.lasting}                 Lv.{LevelGetter(Main.lasting)[0]}";
            label_Lastingleft.Text = LevelGetter(Main.lasting)[1].ToString();
            label_Lastingright.Text = LevelGetter(Main.lasting)[2].ToString();
            //耐力值进度
            int delta = Convert.ToInt32(label_Lastingright.Text) - Convert.ToInt32(label_Lastingleft.Text);
            int lasting = Main.lasting;
            panel_Lasting.Width = (int) (((double) (lasting - Convert.ToInt32(label_Lastingleft.Text)) / (double) delta) * 184);
            //爆发值信息
            label_ExplosiveC.Text = $"爆发值：{Main.explosive}                 Lv.{LevelGetter(Main.explosive)[0]}";
            label_Explosiveleft.Text = LevelGetter(Main.explosive)[1].ToString();
            label_Explosiveright.Text = LevelGetter(Main.explosive)[2].ToString();
            //爆发值进度
            delta = Convert.ToInt32(label_Explosiveright.Text) - Convert.ToInt32(label_Explosiveleft.Text);
            int explosive = Main.explosive;
            panel_Explosive.Width = (int) (((double) (explosive - Convert.ToInt32(label_Explosiveleft.Text)) / (double) delta) * 184);
            //智慧值信息
            label_WisdomC.Text = $"智慧值：{Main.wisdom}                Lv.{LevelGetter(Main.wisdom)[0]}";
            label_Wisdomleft.Text = LevelGetter(Main.wisdom)[1].ToString();
            label_Wisdomright.Text = LevelGetter(Main.wisdom)[2].ToString();
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
#pragma warning disable CS0618 // 'Legacy.Main_Calc()' is obsolete: '该代码存在逻辑问题，应该尽早重构'
            double point_Plan = Legacy.Main_Calc();
#pragma warning restore CS0618 // 'Legacy.Main_Calc()' is obsolete: '该代码存在逻辑问题，应该尽早重构'
            label_Point.Text = $"评 分 值（pp）：{point_User + point_Plan}";
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
            List<int> li = new List<int>();
            li.Add(i-1);
            li.Add(k);
            li.Add(j);
            return li;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
