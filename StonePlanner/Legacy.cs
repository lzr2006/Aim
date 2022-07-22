using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                allTask += item.dwSeconds + ";";
                allTask += item.dwDifficulty;
                allTask += "\n";

                strInsert += "'" + item.capital + "', '";
                strInsert += item.dwIntro + "', '";
                strInsert += item.status + "', ";
                strInsert += item.dwSeconds + ", ";
                strInsert += item.dwDifficulty + ")";
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
            double GGS = 0D;
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
                    Plan plan = new Plan(temp[0], Convert.ToInt32(temp[1]), "LEGACY", provider);
                    GGS += provider;
                    recycle_bin.Add(plan);
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
                Plan plan = new Plan
                    (
                    recy_bin.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    Convert.ToInt32(recy_bin.dataGridView1.Rows[i].Cells[4].Value),
                    recy_bin.dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt64(recy_bin.dataGridView1.Rows[i].Cells[5].Value)
                    );
                GGS += plan.dwDifficulty;
                plan = null;
            }
            return GGS / recy_bin.dataGridView1.Rows.Count;
        }
        #endregion
        #region 编辑器【InnerIDE】废弃代码
        #endregion
    }
}
