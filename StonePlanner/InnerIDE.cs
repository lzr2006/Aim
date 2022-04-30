using MDI;
using StonePlanner.Inner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    public partial class InnerIDE : Form
    {
        public InnerIDE()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        protected string fileNameString = "",fName = "";
        internal ListBox lb;
        protected Boolean stOpenRem = false;
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0x00A1;
            const int HTCAPTION = 2;

            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键   
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);// 拖动窗体  
            }
        }

        private void pictureBox_T_Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void showLineNo()
        {
            //获得当前坐标信息
            Point p = this.richTextBox_Main.Location;
            int crntFirstIndex = this.richTextBox_Main.GetCharIndexFromPosition(p);
            int crntFirstLine = this.richTextBox_Main.GetLineFromCharIndex(crntFirstIndex);
            Point crntFirstPos = this.richTextBox_Main.GetPositionFromCharIndex(crntFirstIndex);
            p.Y += this.richTextBox_Main.Height;
            int crntLastIndex = this.richTextBox_Main.GetCharIndexFromPosition(p);
            int crntLastLine = this.richTextBox_Main.GetLineFromCharIndex(crntLastIndex);
            Point crntLastPos = this.richTextBox_Main.GetPositionFromCharIndex(crntLastIndex);
            //准备画图
            Graphics g = this.panel1.CreateGraphics();
            Font font = new Font(this.richTextBox_Main.Font, this.richTextBox_Main.Font.Style);
            SolidBrush brush = new SolidBrush(Color.Green);
            //刷新画布
            Rectangle rect = this.panel1.ClientRectangle;
            brush.Color = this.panel1.BackColor;
            g.FillRectangle(brush, 0, 0, this.panel1.ClientRectangle.Width, this.panel1.ClientRectangle.Height);
            brush.Color = Color.White;//重置画笔颜色
            //绘制行号
            int lineSpace = 0;
            if (crntFirstLine != crntLastLine)
            {
                lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine);
            }
            else
            {
                lineSpace = Convert.ToInt32(this.richTextBox_Main.Font.Size);
            }
            int brushX = this.panel1.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            int brushY = (crntLastPos.Y - Convert.ToInt32(font.Size * 0.21f)) + Convert.ToInt32(font.Size * 0.21f);//惊人的算法啊！！
            for (int i = crntLastLine; i >= crntFirstLine; i--)
            {
                g.DrawString((i + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        private void richTextBox_Main_TextChanged(object sender, EventArgs e)
        {
            showLineNo();
        }

        private void richTextBox_Main_VScroll(object sender, EventArgs e)
        {
            showLineNo();
        }

        private void InnerIDE_Load(object sender, EventArgs e)
        {

        }

        private unsafe void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char[] szFileNameSize = new char[256];
            fixed (char* fileName = szFileNameSize)
            {
                InputBoxStruct IBS = new InputBoxStruct();
                IBS.lpText = "输入文件名";
                IBS.lpCaption = "请输入文件名";
                IBS.szValueBack = fileName;
                InputBox input = new InputBox(IBS);
                input.Show();
                TaskFactory nameGetThread = new TaskFactory();
                char* temp = fileName;
                nameGetThread.StartNew(() => FileAddition(temp, input));
            }
        }
        public unsafe void FileAddition(char* fileName, InputBox input)
        {
            //FIXED FILENAME AS CONST
            while (true)
            {
                if (input.IN)
                {
                    char* temp = fileName;
                    for (int i = 0; i < 256; i++)
                    {
                        fileNameString += *temp++;
                    }
                    richTextBox_Main.Text += $"//Filename：{fileNameString}\n";
                    input.IN = !input.IN;
                }
            }
        }

        //        foreach (var item in fileName)
        //{
        //    fileNameString += *item;
        //}

        private void 文件FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "MethodBox脚本文件|*.mtd|文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
                MessageBox.Show(fName);
                using (StreamReader sr = new StreamReader(fName))
                {
                    string result = sr.ReadToEnd().Trim();
                    this.richTextBox_Main.Text = result;
                }
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fName))
                {
                    sw.Write(richTextBox_Main.Text);
                    MessageBox.Show("保存成功。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                DialogResult dr = 
                MessageBox.Show($"保存失败，原因是{ex.Message}。\n是否向MethodBox报告该错误（自动报告）？","失败",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    throw ex;
                }
                else
                { }
            }
         
        }
        #region 语法高亮器

        //关键字集
        public static List<string> AllClass()
        {
            List<string> list = new List<string>();
            list.Add("EXIT");
            list.Add("SLEEP");
            list.Add("SET");
            list.Add("SIGN");
            list.Add("REPEAT");
            list.Add("END");
            list.Add("ADD");
            return list;
        }

        //设定颜色
        public static void MySelect(System.Windows.Forms.RichTextBox tb, int i, string s, Color c, bool font)
        {
            try
            {
                tb.Select(i - s.Length, s.Length);
                tb.SelectionColor = c;
                //以下是把光标放到原来位置，并把光标后输入的文字重置
                tb.Select(i, 0);
                tb.SelectionFont = new Font(" Courier New ", 10.5f, (FontStyle.Regular));
                tb.SelectionColor = Color.Black;
            }
            catch { }
        }

        //返回搜索字符
        public static string GetLastWord(string str, int i)
        {
            string x = str;
            Regex reg = new Regex(@"\S+[a-z]+\S*|[a-z]+\S*|\S+[a-z]*", RegexOptions.RightToLeft);
            x = reg.Match(x).Value;
            Regex reg2 = new Regex(@"\s");
            x = reg2.Replace(x, "");
            return x;
        }
        #endregion
        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\temp\pFile{new Random().Next(100000, 999999)}.txt";
            File.Create(path).Close();
            StreamWriter sw = new StreamWriter(path);
            sw.Write(richTextBox_Main.Text);
            sw.Close();
            Inner.InnerFuncs.CmdExecuter.RunCmd($"notepad {path}");
        }

        private void 打印预览VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $@"{Application.StartupPath}\temp\pFile{new Random().Next(100000, 999999)}.txt";
            File.Create(path).Close();
            StreamWriter sw = new StreamWriter(path);
            sw.Write(richTextBox_Main.Text);
            sw.Close();
            Inner.InnerFuncs.CmdExecuter.RunCmd($"notepad {path}");
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Undo();
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Redo();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Cut();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Copy();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Paste();
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.SelectAll();
        }

        private void DateTimeDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Main.Text += DateTime.Now.ToString();
        }
        //可访问性权限引子
        public RichTextBox rtbMain
        {
            get { return this.richTextBox_Main; }
            set { this.richTextBox_Main = value; }
        }

        private void FindFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finder fd = new Finder(this);
            fd.Show();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void richTextBox_Main_KeyDown(object sender, KeyEventArgs e)
        {
            //语法高亮
            string s = GetLastWord(richTextBox_Main.Text, richTextBox_Main.SelectionStart);
            if (AllClass().IndexOf(s) > -1)
            {
                MySelect(richTextBox_Main, richTextBox_Main.SelectionStart, s, Color.CadetBlue, true);
            }
            if (stOpenRem)
            {
                //语法提示
                RichTextBox tb = (RichTextBox)sender;
                if (true)
                {
                    //搜索ListBox是否已经被创建
                    Control[] c = tb.Controls.Find("mylb", false);
                    if (c.Length > 0)
                        ((ListBox)c[0]).Dispose();  //如果被创建则释放
                    lb = new ListBox();
                    lb.Name = "mylb";
                    string lastWord = GetLastWord(richTextBox_Main.Text, 1);
                    foreach (var item in AllClass())
                    {
                        if (item.Contains(lastWord))
                            lb.Items.Add(item);
                    }
                    lb.Show();
                    lb.TabIndex = 100;
                    lb.Location = tb.GetPositionFromCharIndex(tb.SelectionStart);
                    lb.Left += 10;
                    tb.Controls.Add(lb);
                    //添加事件
                    lb.Focus();
                    lb.KeyPress += new KeyPressEventHandler(this.ListBoxRemind_Enter);
                }
            }
        }
        #region 语法提示框关键事件
        protected void ListBoxRemind_Enter(object sender,KeyPressEventArgs e) 
        {
            if (e.KeyChar == 13) 
            {
                string lastWord = GetLastWord(richTextBox_Main.Text,1);
                int lastWordLength = lastWord.Length;
                string temp = richTextBox_Main.Text.Substring(0, richTextBox_Main.Text.Length - lastWord.Length);
                richTextBox_Main.Text = temp;
                richTextBox_Main.Text += lb.SelectedItem;
            }
            if (e.KeyChar == 32)
            {
                lb.Dispose();
            }
            if (e.KeyChar == 37)
            {
                richTextBox_Main.Focus();
            }
        }
        #endregion

        private void 搜索SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finder fd = new Finder(this);
            fd.Show();
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox_Main.Text);
        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://afdian.net/@MethodBox");
        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 20)
            {
                lb.Dispose();
            }
            if (e.KeyChar == 37)
            {
                richTextBox_Main.Focus();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stOpenRem = !stOpenRem;
        }

        private unsafe void 中文插入CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //char szBufferSize;
            //char* chineseText = &szBufferSize;
            //InputBoxStruct IBS = new InputBoxStruct();
            //IBS.lpText = "请输入您想插入的中文";
            //IBS.lpCaption = "中文插入系统";
            //IBS.szValueBack = chineseText;
            //InputBox IB = new InputBox(IBS);
            //IB.Show();
            //TaskFactory nameGetThread = new TaskFactory();
            //nameGetThread.StartNew(() => FileAddition(chineseText, IB));
            Inner.InnerFuncs.CmdExecuter.RunCmd("notepad");
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //可能要获取的路径名
            string localFilePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //书写规则例如：txt files(*.txt)|*.txt
            saveFileDialog.Filter = "MethodBox脚本文件|*.mtd|文本文件|*.txt|所有文件|*.*";
            //主设置默认文件extension（可以不设置）
            saveFileDialog.DefaultExt = "mtd";
            //获取或设置一个值，该值指示如果用户省略扩展名，文件对话框是否自动在文件名中添加扩展名。（可以不设置）
            saveFileDialog.AddExtension = true;
            //保存对话框是否记忆上次打开的目录
            saveFileDialog.RestoreDirectory = true;
            // Show save file dialog box
            DialogResult result = saveFileDialog.ShowDialog();
            //点了保存按钮进入
            if (result == DialogResult.OK)
            {
                //获得文件路径
                localFilePath = saveFileDialog.FileName.ToString();
                using (StreamWriter sw = new StreamWriter(localFilePath))
                {
                    sw.Write(richTextBox_Main.Text);
                    MessageBox.Show("保存成功。", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
