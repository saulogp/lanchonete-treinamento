using Lanchonete.Model;
using Lanchonete.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lanchonete.Data
{
    public class LogDB : ILogDB
    {
        private ConnectionDB _conn;

        public void Insert(string log)
        {
            string sql = string.Format(Log.INSERT, log);

            using (_conn = new ConnectionDB())
            {
                _conn.RunSQL(sql);
            }
        }

        public List<Log> Select()
        {
            string sql = Log.SELECT;

            using (_conn = new ConnectionDB())
            {
                var returnData = _conn.RunSqlReturn(sql);
                return ConverteSQLReaderToList(returnData);
            }
        }
        private List<Log> ConverteSQLReaderToList(SqlDataReader returnData)
        {
            List<Log> list = new List<Log>();

            while (returnData.Read())
            {
                Log log = new Log
                {
                    DateInformation = DateTime.Parse(returnData["dateInformation"].ToString()),
                    Descricao = returnData["descricao"].ToString()
                };

                list.Add(log);
            }
            return list;
        }
    }
}