using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class UserInfo : Form
    {
        internal UserInfo(Structs.UserStruct stroo)
        {
            InitializeComponent();

            this.stroo = stroo;
        }

        Structs.UserStruct stroo;

        private void UserInfo_Load(object sender, EventArgs e)
        {

            //你猜我为什么写在这儿
            //用户基本信息
            label_Username.Text = $"用 户 名：{stroo.userName}";
            label_Money.Text = $"金 币 数 量：{stroo.userMoney}";
            //耐力值信息
            label_LastingC.Text = $"耐力值：{stroo.userLasting}                 Lv.{LevelGetter(stroo.userLasting)[0]}";
            label_Lastingleft.Text = LevelGetter(stroo.userLasting)[1].ToString();
            label_Lastingright.Text = LevelGetter(stroo.userLasting)[2].ToString();
            //耐力值进度
            int delta = Convert.ToInt32(label_Lastingright.Text) - Convert.ToInt32(label_Lastingleft.Text);
            int lasting = stroo.userLasting;
            panel_Lasting.Width = (int) (((double) (lasting - Convert.ToInt32(label_Lastingleft.Text)) / (double) delta) * 184);
            //爆发值信息
            label_ExplosiveC.Text = $"爆发值：{stroo.userExplosive}                 Lv.{LevelGetter(stroo.userExplosive)[0]}";
            label_Explosiveleft.Text = LevelGetter(stroo.userExplosive)[1].ToString();
            label_Explosiveright.Text = LevelGetter(stroo.userExplosive)[2].ToString();
            //爆发值进度
            delta = Convert.ToInt32(label_Explosiveright.Text) - Convert.ToInt32(label_Explosiveleft.Text);
            int explosive = stroo.userExplosive;
            panel_Explosive.Width = (int) (((double) (explosive - Convert.ToInt32(label_Explosiveleft.Text)) / (double) delta) * 184);
            //智慧值信息
            label_WisdomC.Text = $"智慧值：{stroo.userWisdom}                Lv.{LevelGetter(stroo.userWisdom)[0]}";
            label_Wisdomleft.Text = LevelGetter(stroo.userWisdom)[1].ToString();
            label_Wisdomright.Text = LevelGetter(stroo.userWisdom)[2].ToString();
            //智慧值进度
            delta = Convert.ToInt32(label_Wisdomright.Text) - Convert.ToInt32(label_Wisdomleft.Text);
            int wisdom = stroo.userWisdom;
            panel_Wisdom.Width = (int) (((double) (wisdom - Convert.ToInt32(label_Wisdomleft.Text)) / (double) delta) * 184);
            //综合评分
            double point_User = lasting * 0.05 + wisdom * 0.02 + explosive * 0.01;
            if (point_User > 6)
            {
                point_User = 6d;
            }
            label_Point.Text = $"评 分 值（pp）：不允许";
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
