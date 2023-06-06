using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace StonePlanner
{
    public partial class Register : MetroForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);
        int GW_CHILD = 5;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        public const int EM_SETREADONLY = 0xcf;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox_M_Pwd.UseSystemPasswordChar = true;
            IntPtr editHandle = GetWindow(comboBox_M_Type.Handle, GW_CHILD);
            SendMessage(editHandle, EM_SETREADONLY, 1, 0);
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_M_Name.Text.Length == 0 || textBox_M_Pwd.Text.Length == 0)
            {
                MessageBox.Show("请输入用户名或密码！","注册失败",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            //确认用户名密码是否符合规则
            Regex regex = new Regex("^[\u4E00-\u9FA5A-Za-z0-9]+$");
            Match result = regex.Match(textBox_M_Name.Text);
            if (!(regex.Match(textBox_M_Name.Text).Success) && (regex.Match(textBox_M_Pwd.Text).Success))
            {
                MessageBox.Show("您输入的用户名或密码含有特殊字符", "注册失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (comboBox_M_Type.Text != "Administrator" && comboBox_M_Type.Text != "Standard")
            {
                comboBox_M_Type.Text = "Standard";
            }
            int i = comboBox_M_Type.Text == "Administrator" ? 0 : 1;
            //创建一个恢复用KEY
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[30];
            var random = new Random();
            for (int j = 0; j < Charsarr.Length; j++)
            {
                Charsarr[j] = characters[random.Next(characters.Length)];
            }
            var resultString = new String(Charsarr);
            SQLConnect.SQLCommandExecution($" INSERT INTO Users (Username , Cmoney , Type , Pwd , Rkey) VALUES ('{textBox_M_Name.Text}' , 0 , {i} , '{textBox_M_Pwd.Text}','{resultString}')"/*cmd*/, ref Main.odcConnection);
            MessageBox.Show($"以下是您的用户恢复密钥：\n{resultString}\n请妥善保管该密钥，您将不会再次看到它了。按确定键复制到剪贴板。");
            Clipboard.SetText(resultString);
            Close();
        }
    }
}
