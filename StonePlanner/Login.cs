using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class Login : Form
    {
        public static string UserName;
        public static int UserType;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox_M_Pwd.UseSystemPasswordChar = true;
           // MessageBox.Show("This program is protected by unregistered ASProtect.","ASProtect",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
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
    }
}
