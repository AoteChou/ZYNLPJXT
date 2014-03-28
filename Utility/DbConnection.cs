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
    /// <summary>
    /// 数据库连接辅助类. 每次使用DbConnection请务必调用CloseDbCon()进行手动关闭数据库
    /// </summary>
    public class DbConnection
    {
         private static string SqlConUrl = ConfigurationManager.AppSettings["connectionStr"];

        
         private SqlConnection sqlCon=null;

         public DbConnection() {
             sqlCon = new SqlConnection(SqlConUrl);
             sqlCon.Open();
         }


         ///<summary>
         ///执行查询的Sql语句。使用完需要手动调用closeDbCon函数
         ///</summary>
        public SqlDataReader executeQuery(string sql) {

            SqlCommand sqlCom = new SqlCommand(sql,sqlCon);
            SqlDataReader reader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection) ;                
            return reader;
        }


        /// <summary>
        /// 执行非Sql查询操作，如：update，delete和insert操作。使用完需要手动调用closeDbCon函数
        /// </summary>
        /// <param name="sql">须执行的Sql语句</param>
        /// <param name="sqlparameters">参数数组</param>
        /// <returns>影响的行数</returns>
        public int executeNonQuery(string sql) {
            SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
            int effectedRows=sqlCom.ExecuteNonQuery();
            return effectedRows;
        }
        ///<summary>
        ///执行查询的Sql语句。使用完需要手动调用closeDbCon函数
        ///</summary>
        public SqlDataReader executeQuery(string sql,SqlParameter[] sqlparameters)
        {

            SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
            sqlCom.Parameters.AddRange(sqlparameters);
            SqlDataReader reader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }


        /// <summary>
        /// 执行非Sql查询操作，如：update，delete和insert操作。使用完需要手动调用closeDbCon函数
        /// </summary>
        /// <param name="sql">须执行的Sql语句</param>
        /// <param name="sqlparameters">参数数组</param>
        /// <returns>影响的行数</returns>
        public int executeNonQuery(string sql,SqlParameter[] sqlparameters)
        {
            SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
            sqlCom.Parameters.AddRange(sqlparameters);
            int effectedRows = sqlCom.ExecuteNonQuery();
            return effectedRows;
        }



       



        /// <summary>
        /// 关闭数据连接
        /// </summary>
        public void closeDbCon() {
            if (sqlCon.State != ConnectionState.Closed) {
                sqlCon.Close();
            }
        }

              
    }
}