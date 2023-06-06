using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StonePlanner
{
    /// <summary>
    /// 此类内含所有已经被废弃的代码 以供查阅
    /// </summary>

    /*
     * 屎山 屎山 屎山
     * 下次写代码 不要用屁股写
     */
    internal static class Legacy
    {
        #region 主窗口【Main】废弃代码
        [Obsolete("该代码重新读取与写入占用大量内存",true)]
        /// <summary>
        /// 原主窗口关闭时执行的函数 功能是存储所有已保存的任务
        /// </summary>
        internal static void Main_ExitMemory() 
        {
            List<Plan> recycle_bin = new List<Plan>();
            //存储
            string allTask = "";
            //链接数据库
            string strConn = $" Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = {Application.StartupPath}\\data.mdb;Jet OLEDB:Database Password={Main.password}";
            OleDbConnection myConn = new OleDbConnection(strConn);
            myConn.Open();
            //删库
            OleDbCommand inst = new OleDbCommand("DELETE * FROM Tasks", myConn);
            inst.ExecuteNonQuery();
            foreach (var item in recycle_bin)
            {
                string strInsert = " INSERT INTO Tasks ( TaskName , TaskIntro , TaskStatus , TaskTime , TaskDiff ) VALUES ( ";
                allTask += item.capital + ";";
                //allTask += item.dwAim + ";";
                allTask += item.seconds + ";";
                allTask += item.difficulty;
                allTask += "\n";

                strInsert += "'" + item.capital + "', '";
                strInsert += item.intro + "', '";
                strInsert += item.status + "', ";
                strInsert += item.seconds + ", ";
                strInsert += item.difficulty + ")";
                //清空原有数据
                inst = new OleDbCommand(strInsert, myConn);
                int lines = inst.ExecuteNonQuery();
                System.Console.WriteLine($"任务总数：{lines}");
            }
            myConn.Close();
            using (StreamWriter swA = new StreamWriter(Application.StartupPath + @"\TaskMemory.txt", true))
            {
                swA.Write(allTask);
            }
            allTask = null;
            //金钱
             StreamWriter sw = new StreamWriter($@"{Application.StartupPath}\temp\pFile114514.txt");
        }

        [Obsolete("该代码读取大量文件，占用大量内存",true)]
        /// <summary>
        /// 原主窗口加载函数 功能是读取所有的任务
        /// </summary>
        internal static void Main_LoadMemory() 
        {
            List<Plan> recycle_bin = new List<Plan>();
            string allTask;
#pragma warning disable CS0219 // The variable 'GGS' is assigned but its value is never used
            double GGS = 0D;
#pragma warning restore CS0219 // The variable 'GGS' is assigned but its value is never used
            using (StreamReader sr = new StreamReader(Application.StartupPath + @"\TaskMemory.txt"))
            {
                allTask = sr.ReadToEnd();
            }
            string[] taskListString = allTask.Split('\n');

            taskListString = taskListString.Take(taskListString.Count() - 1).ToArray();

            //Plan数据存储集
            List<string> planCapital = new List<string>();
            List<int> planSecond = new List<int>();
            List<string> planIntro = new List<string>();
            List<double> planDifficulty = new List<double>();
            //链接数据库
            OleDbConnection conn = new OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\\data.mdb"); //Jet OLEDB:Database Password=
            OleDbCommand cmd = conn.CreateCommand();
            //读取数据
            cmd.CommandText = "select * from Tasks";
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            //分类获取
            for (int i = 0; i < dr.FieldCount; i++)
            {
                //Line0 => ID
                //Line1 => NAME
                //Line2 => INTRO
                //Line3 => STATUS
                //Line4 => TIME
                //Line5 => DIFF
            }
            foreach (var item in taskListString)
            {
                try
                {
                    string[] temp = item.Split(';');
                    double provider = double.Parse(temp[2], System.Globalization.NumberStyles.Float);
                    //挺怀念的，之前的方式
                    //Plan plan = new Plan(temp[0], Convert.ToInt32(temp[1]), "LEGACY", provider,"");
                    //GGS += provider;
                    //recycle_bin.Add(plan);
                }
                catch (Exception ex) { throw ex; }
            }
        }

        [Obsolete("该代码存在逻辑问题，应该尽早重构",false)]
        /// <summary>
        /// 原评分计算函数，算法优化不好导致很卡顿
        /// </summary>
        /// <returns>评分值</returns>
        internal static double Main_Calc() 
        {
            double GGS = 0;
            Recycle recy_bin = new Recycle();
            for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            {
                //你干嘛要重新建立Plan捏
                //Plan plan = new Plan
                //    (
                //    recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                //    recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                //    Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value),
                //    ""
                //    );
                GGS += (double)Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value);
                // plan = null;
            }
            return GGS / recy_bin.dataGridView1.Rows.Count;
        }
        #endregion

        /// <summary>
        /// 原外部评分函数
        /// </summary>
        [Obsolete("该代码获取数据方式及其奇怪，不应被使用")]
        
        internal static void GetPoint() 
        {
            //人类迷惑行为 获取数据
            Recycle recy_bin = new Recycle();
            int GGS = 0;
            for (int i = 0; i < recy_bin.dataGridView1.Rows.Count - 1; i++)
            {
                //Plan plan = new Plan
                //    (
                //    recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                //    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                //    recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                //    Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value),
                //    ""
                //    );
                GGS += (int)Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value);
                // plan = null;
            }
        }

        //internal unsafe void PlanAdder(Plan pValue, PlanClassD @struct)
        //{
        //    /*
        //     * 这个奇怪的函数真是令人费解
        //     * 已经传入了Plan了 您老是不会自己提提参数吗
        //     * 况且有地方有 有地方没有
        //     * 总言而之 屁用没有
        //     * 个人认为开发者脑子有病
        //     * 是的 是指我自己
        //     */

        //    //分配唯一编号
        //    int thisNumber = -1;
        //    for (int i = 0; i < 100; i++)
        //    {
        //        if (TasksDict[i] == null)
        //        {
        //            thisNumber = i;
        //            break;
        //        }
        //    }
        //    if (thisNumber == -1) { return; }
        //    pValue.Top = 36 * thisNumber;
        //    //获取结构体
        //    //PlanClassD @struct = Pointer.Box((void*)pStruct, typeof(PlanClassD)) as PlanClassD;
        //    //设置任务标题
        //    pValue.capital = @struct.lpCapital;
        //    //内置编号
        //    pValue.Lnumber = thisNumber;
        //    //添加时间
        //    pValue.dwSeconds = @struct.iSeconds;
        //    //添加难度
        //    pValue.dwDifficulty = @struct.dwDifficulty;
        //    //添加耐力值
        //    pValue.dwLasting = @struct.iLasting;
        //    //添加爆发值
        //    pValue.dwExplosive = @struct.iExplosive;
        //    //添加智慧值
        //    pValue.dwWisdom = @struct.iWisdom;
        //    //添加开始时间
        //    pValue.dtStartTime = DateTime.FromBinary(@struct.dwStart);
        //    //添加到字典
        //    TasksDict[thisNumber] = pValue;
        //    panel_M.Controls.Add(pValue);
        //}

        #region 编辑器【InnerIDE】废弃代码
        #endregion
        #region 登录窗口【Login】废弃代码
        public static void Login()
        {
            try
            {
                var result = SQLConnect.SQLCommandQuery($"SELECT Pwd FROM Users where Username='';");
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
                //    dataGridView1.DataSource = dt;
                //    if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "")
                //    {
                //        MessageBox.Show("账号不存在！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }

                //    if (dataGridView1.Rows[0].Cells[0].Value.ToString() == textBox_M_Pwd.Text)
                //    {
                //        result = SQLConnect.SQLCommandQuery($"SELECT Type FROM Users where Username='{textBox_M_Name.Text}';");
                //        dt = new DataTable();
                //        if (result.HasRows)
                //        {
                //            for (int i = 0; i < result.FieldCount; i++)
                //            {
                //                dt.Columns.Add(result.GetName(i));
                //            }
                //            dt.Rows.Clear();
                //        }
                //        while (result.Read())
                //        {
                //            DataRow row = dt.NewRow();
                //            for (int i = 0; i < result.FieldCount; i++)
                //            {
                //                row[i] = result[i];
                //            }
                //            dt.Rows.Add(row);
                //        }
                //        dataGridView1.DataSource = dt;
                //        //特殊用户
                //        try
                //        {
                //            UserType = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
                //            if (UserType == 2)
                //            {
                //                Testify ti = new Testify();
                //                ti.Show();
                //                new ErrorCenter().Show();
                //            }
                //            MessageBox.Show("登录成功", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            Hide();
                //            UserName = textBox_M_Name.Text;
                //            Main m = new Main();
                //            m.Show();
                //            //Thread td = new Thread(new ThreadStart(
                //            //    () => Application.Run(new Main())
                //            //    )) ;
                //        }
                //        catch (Exception ex)
                //        {
                //            MessageBox.Show("读取用户时出现异常，详情请见错误中心", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //            ErrorCenter.AddError(DateTime.Now.ToString(), "Error", ex);
                //            return;
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("用户名或密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show("不存在该用户!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch { }
        #endregion
        }
    }
}
