using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
namespace RagnarokWeb.Codes
{
    public class DataBase
    {
        private string dbPath = @"C:\ragnarokdb\BancoPortal.mdb";
        OleDbConnection conn;
        OleDbCommand cmd;
        /// <summary>
        /// Executa construtor interno e abre conexao padrão local
        /// </summary>
        public DataBase()
        {
            this.open();
        }

        /// <summary>
        /// Contrutor para conexão via host
        /// </summary>
        /// <param name="host">Nome ou caminho do host</param>
        /// <param name="user">Nome de usuasrio</param>
        /// <param name="pwd">Senha do banco para ususario</param>
        public DataBase(string host,string user,string pwd)
        {

        }

        public void open()
        {
           if(conn == null)
            {
                this.conn = new OleDbConnection();
                this.cmd = new OleDbCommand();
                conn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + dbPath;
                cmd.Connection = conn;
                conn.Open();
            }
        }

        public void close()
        {
            if (conn != null)
                conn.Close();
        }

        /// <summary>
        /// Execute a non query  e retorna o numero de linhas afetadas nesta query
        /// </summary>
        /// <param name="sql">query sql completa</param>
        /// <returns>int - numero de linhas afetadas pela query</returns>
        public int ExecuteCmd(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Executa e retorna um DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>Objet - fazer Cast Para OleDbDataReader</returns>
        public Object ReturnQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteReader();
        }
    }
}