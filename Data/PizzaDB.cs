using Lanchonete.Model;
using Lanchonete.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lanchonete.Data
{
    public class PizzaDB : IPizzaDB
    {
        private ConnectionDB _conn;
        public bool Insert(Pizza pizza)
        {
            bool status = false;
            string cmd = String.Format(Pizza.Insert, pizza.Descricao, pizza.Valor);
            string cmdFK = String.Format(Pizza.InsertFK, pizza.Descricao, pizza.Valor);

            using (_conn = new ConnectionDB())
            {
                _conn.RunSQL(cmd);
                status = _conn.RunSQL(cmdFK);
            }
            return status;
        }

        public List<Pizza> Select()
        {
            string cmd = Pizza.Select;
            using (_conn = new ConnectionDB())
            {
                var retorno = _conn.RunSqlReturn(cmd);
                return ConverteSQLReaderToList(retorno);
            }

        }

        private List<Pizza> ConverteSQLReaderToList(SqlDataReader sqlReader)
        {
            List<Pizza> lista = new List<Pizza>();

            while (sqlReader.Read())
            {
                var pizza = new Pizza()
                {
                    Id = int.Parse(sqlReader["id"].ToString()),
                    Descricao = sqlReader["descricao"].ToString(),
                    Valor = decimal.Parse(sqlReader["valor"].ToString())
                };
                lista.Add(pizza);
            }

            return lista;
        }
    }
}