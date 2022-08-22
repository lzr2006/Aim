using System.Data.OleDb;
using System.Windows.Forms;

namespace StonePlanner
{
    internal static class SQLConnect
    {
        internal static void SQLCommandExecution(string cmd, string pwd) 
        {
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\DataBase.mdb;Jet OLEDB:Database Password={pwd}";
            OleDbConnection odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            odcConnection.Open(); //建立SQL查询   
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = cmd; //建立读取 C#操作Access之按列读取mdb;
            odCommand.ExecuteNonQuery();
        }

        internal static OleDbDataReader SQLCommandQuery(string cmd,string pwd)
        {
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\DataBase.mdb;Jet OLEDB:Database Password={pwd}";
            OleDbConnection odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            odcConnection.Open(); //建立SQL查询   
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = cmd; //建立读取 C#操作Access之按列读取mdb;
            var result = odCommand.ExecuteReader();
            return result;
        }

        internal static OleDbDataReader SQLCommandQuery(string cmd,ref OleDbConnection odcConnection, string pwd)
        {
            string strConn = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\DataBase.mdb;Jet OLEDB:Database Password={pwd}";
            odcConnection = new OleDbConnection(strConn); //2、打开连接 C#操作Access之按列读取mdb   
            odcConnection.Open(); //建立SQL查询   
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = cmd; //建立读取 C#操作Access之按列读取mdb;
            var result = odCommand.ExecuteReader();
            return result;
        }
    }
}
