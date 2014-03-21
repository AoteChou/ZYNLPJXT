using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ZYNLPJXT.Utility
{
    public class DbConnection
    {
         private static string SqlConUrl = ConfigurationManager.AppSettings["connectionStr"];


        //使用datareader关闭连接
        public SqlDataReader executeQuery(string sql) {

            SqlConnection con = new SqlConnection(SqlConUrl);
            con.Open();
            SqlCommand sqlCom = new SqlCommand(sql,con);
            SqlDataReader reader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection) ;                
            return reader;
        }
       
              
    }
}