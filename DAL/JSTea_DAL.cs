using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 教师数据库访问层
    /// </summary>
    public class JSTea_DAL
    {

        /// <summary>
        /// 插入教师。逻辑层需要保证教师实体中不出现默认值,因为教师实体没有可空字段。
        /// </summary>
        /// <param name="jsTea"></param>
        /// <returns></returns>
        public bool insert(JS_Tea jsTea) {

            string sql = "insert into JS (JSBH,SFSXKFZR,SFSKCFZR) values (@jsbh,@sfsxkfzr,@sfskcfzr)";
            SqlParameter[] sqlPar = { new SqlParameter("@jsbh", jsTea.Jsbh),
                                    new SqlParameter("@sfsxkfzr",jsTea.Sfsxkfzr),
                                    new SqlParameter("@sfskcfzr",jsTea.Sfskcfzr)
                                    };
            DbConnection dbCon = new DbConnection();
            bool executedResult =false;
            if (dbCon.executeNonQuery(sql, sqlPar) > 0)
                executedResult = true;
            else
                executedResult = false;
            dbCon.closeDbCon();
            return executedResult;
        }

        /// <summary>
        /// 更新教师实体。需要确保教师的主键不为默认字段。
        /// </summary>
        /// <param name="jsTea"></param>
        /// <returns></returns>
        public bool update(JS_Tea jsTea) {

            string sql = "update JS SET SFSXKFZR=@sfsxkfzr, SFSKCFZR=@sfskcfzr where JSBH=@jsbh ";
            SqlParameter[] sqlPars = { 
                                         new SqlParameter("@sfsxkfzr", jsTea.Sfsxkfzr),
                                         new SqlParameter("@sfskcfzr", jsTea.Sfskcfzr),
                                         new SqlParameter("@jsbh",jsTea.Jsbh)
                                     };
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql, sqlPars) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }

        /// <summary>
        /// 获取所有教师信息
        /// </summary>
        /// <returns></returns>
        public JS_Tea[] getAll()
        {
            string sql = "select * from JS";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JS_Tea> list = new List<JS_Tea>();
            while (reader.Read())
            {
                list.Add(new JS_Tea((string)reader["jsbh"],(Int16)reader["sfsxkfzr"],(Int16)reader["sfskcfzr"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 根据教师编号获取指定教师的信息。如果没有查找到指定教师的信息，那么返回的实体的字段为默认值。即数字为-1，字符串为""
        /// </summary>
        public JS_Tea getJSTeaById(string _jsbh)
        {

            string sql = "select * from JS where jsbh=@jsbh";
            SqlParameter[] sqlPars = { new SqlParameter("@jsbh", _jsbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            JS_Tea jsTea = new JS_Tea();
            if (reader.Read())
            {
                jsTea.Jsbh=(string)reader["jsbh"];
                jsTea.Sfskcfzr=(Int16)reader["sfskcfzr"];
                jsTea.Sfsxkfzr=(Int16)reader["sfsxkfzr"];
            }
            dbCon.closeDbCon();
            return jsTea;
        }

    }
}