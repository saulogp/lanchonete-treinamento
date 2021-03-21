using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Data;

namespace Lanchonete.Util
{
    public class ConnectionDB : IDisposable
    {
        private static SqlConnection _conn;

        public ConnectionDB()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TWConnection"].ConnectionString);
            _conn.Open();
        }

        public bool RunSQL(string cmd)
        {
            var exe = new SqlCommand { CommandText = cmd, CommandType = CommandType.Text, Connection = _conn };
            return exe.ExecuteNonQuery() == 1 ? true : false;
        }

        public SqlDataReader RunSqlReturn(string cmd)
        {
            var exe = new SqlCommand(cmd, _conn);
            return exe.ExecuteReader();

        }
        public void Dispose()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }


    }
}