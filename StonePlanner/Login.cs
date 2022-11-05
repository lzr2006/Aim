using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Login : Form
    {
        public static string UserName;
        public static int UserType;
        int h = 65;
        bool test = false;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private void Login_Load(object sender, EventArgs e)
        {
            textBox_M_Pwd.UseSystemPasswordChar = true;
            label_Login.Parent = pictureBox_Bg;
            label_Login.Location = new Point(78, h);
            textBox_M_Name.Parent = pictureBox_Bg;
            textBox_M_Name.Location = new Point(55, h + 40);
            PictureBox pbox_User = new PictureBox();
            pictureBox_Bg.Controls.Add(pbox_User);
            pbox_User.BackgroundImageLayout = ImageLayout.Stretch;
            pbox_User.BackgroundImage = Image.FromFile(Application.StartupPath + @"\icon\user.png");
            pbox_User.BackColor = Color.Transparent;
            pbox_User.Width = 25;
            pbox_User.Height = 25;
            pbox_User.Location = new Point(25, h + 40);
            PictureBox pbox_Password = new PictureBox();
            pictureBox_Bg.Controls.Add(pbox_Password);
            pbox_Password.BackgroundImageLayout = ImageLayout.Stretch;
            pbox_Password.BackgroundImage = Image.FromFile(Application.StartupPath + @"\icon\password.png");
            pbox_Password.BackColor = Color.Transparent;
            pbox_Password.Width = 25;
            pbox_Password.Height = 25;
            pbox_Password.Location = new Point(25, h + 80);
            textBox_M_Pwd.Parent = pictureBox_Bg;
            textBox_M_Pwd.Location = new Point(55, h + 80);
            textBox_M_Pwd.Width = textBox_M_Name.Width;
            Label label_Logon = new Label();
            label_Logon.Text = "Log On →";
            label_Logon.ForeColor = Color.Black;
            label_Logon.Font = new Font(new FontFamily("SimHei"), 12, FontStyle.Regular);
            label_Logon.Location = new Point(170, 38);
            label_Logon.BackColor = Color.Transparent;
            label_Logon.Click += (object sender, EventArgs e) => { new Register().Show(); };
            pictureBox_Bg.Controls.Add(label_Logon);
            PictureBox pbox_Login = new PictureBox();
            pictureBox_Bg.Controls.Add(pbox_Login);
            pbox_Login.BackgroundImageLayout = ImageLayout.Stretch;
            pbox_Login.BackgroundImage = Image.FromFile(Application.StartupPath + @"\icon\skin\Login.png");
            pbox_Login.BackColor = Color.Transparent;
            pbox_Login.Width = 240;
            pbox_Login.Height = 50;
            pbox_Login.Location = new Point(10, h + 115);
            pbox_Login.Click += button_Submit_Click;
            LinkLabel label_NoLogin = new LinkLabel();
            //测试用限制代码
            if (test)
            {
                textBox_M_Name.Text = "Epsilon_Tester";
                textBox_M_Name.ReadOnly = true;
            } 
        }
        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_M_Name.Text == "Epsilon_Tester")
            {
                if (License.Code.codes.Contains(textBox_M_Pwd.Text))
                {
                    textBox_M_Pwd.Text = "A5S4F0v254G54&hsuQ";
                }
                else
                {
                    MessageBox.Show("激活码输入错误","登陆失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            try
            {
                var result = SQLConnect.SQLCommandQuery($"SELECT Pwd FROM Users where Username='{textBox_M_Name.Text}';");
                DataTable dt = new DataTable();
                if (result.HasRows)
                {
                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        dt.Columns.Add(result.GetName(i));
                    }
                    dt.Rows.Clear();
                }
                while (result.Read())
                {
                    DataRow row = dt.NewRow();
                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        row[i] = result[i];
                    }
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("账号不存在！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (AESEncrypt.Encrypt(dataGridView1.Rows[0].Cells[0].Value.ToString(), Main.password) == AESEncrypt.Encrypt(textBox_M_Pwd.Text, Main.password))
                {
                    result = SQLConnect.SQLCommandQuery($"SELECT Type FROM Users where Username='{textBox_M_Name.Text}';");
                    dt = new DataTable();
                    if (result.HasRows)
                    {
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            dt.Columns.Add(result.GetName(i));
                        }
                        dt.Rows.Clear();
                    }
                    while (result.Read())
                    {
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            row[i] = result[i];
                        }
                        dt.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dt;
                    try
                    {
                        UserType = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
                        if (UserType == 2)
                        {
                            Testify ti = new Testify();
                            ti.Show();
                            new ErrorCenter().Show();
                        }
                        if (textBox_M_Name.Text == "HK_ME")
                        {
                            Hide();
                            UserName = textBox_M_Name.Text;
                            Main mm = new Main();
                            mm.Show();
                            textBox_M_Name.Text = "";
                            textBox_M_Pwd.Text = "";
                            return;
                        }
                        MessageBox.Show("登录成功", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        UserName = textBox_M_Name.Text;
                        Main m = new Main();
                        m.Show();
                        //Thread td = new Thread(new ThreadStart(
                        //    () => Application.Run(new Main())
                        //    )) ;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("读取用户时出现异常，详情请见错误中心", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("不存在该用户!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void linkLabel_Nll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_M_Name.Text = "HK_ME";
            textBox_M_Pwd.Text = "HK_PassWord";
            button_Submit_Click(null, null);
        }
    }
}
