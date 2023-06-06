using System;
using System.Data;
using System.Data.OleDb;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Login : MetroForm
    {
        public static string UserName;
        public static int UserType;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;  
            textBox_M_Pwd.UseSystemPasswordChar = true;
           // MessageBox.Show("This program is protected by unregistered ASProtect.","ASProtect",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        private void button_Submit_Click(object sender, EventArgs e)
        {
            //该逻辑依赖于DataTable，实际上没什么用，急需重写
            var account = SQLConnect.SQLCommandQuery(
                $"SELECT Pwd FROM Users where Username='{textBox_M_Name.Text}';");
            if (!account.HasRows)
            {
                MessageBox.Show("账号不存在！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //存在相应账户
                account.Read();
                string password = account["Pwd"].ToString();
                if (textBox_M_Pwd.Text == password)
                {
                    MessageBox.Show("登录成功", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    UserName = textBox_M_Name.Text;
                    Main m = new Main();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkLabel_GetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("准备进入找回密码流程，请准备：\n1、您的用户名；\n2、您的用户密钥；\n3、证明材料（可选择）。","找回密码"
                ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show("还未开发完毕！", "找回密码", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
        }
    }
}
