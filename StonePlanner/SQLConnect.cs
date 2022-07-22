using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    internal static class SQLConnect
    {
        internal static void SQLCommandExecution(string cmd) 
        {
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={Main.password}";
            OleDbConnection odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            odcConnection.Open(); //建立SQL查询   
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = cmd; //建立读取 C#操作Access之按列读取mdb;
            odCommand.ExecuteNonQuery();
        }

        internal static OleDbDataReader SQLCommandQuery(string cmd)
        {
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\data.mdb;Jet OLEDB:Database Password={Main.password}";
            OleDbConnection odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            odcConnection.Open(); //建立SQL查询   
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = cmd; //建立读取 C#操作Access之按列读取mdb;
            var result = odCommand.ExecuteReader();
            return result;
        }
    }
}
