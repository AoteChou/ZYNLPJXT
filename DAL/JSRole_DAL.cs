using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using System.Data.SqlClient;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 角色数据库访问层
    /// </summary>
    public class JSRole_DAL
    {

        /// <summary>
        ///插入角色JS实体 
        /// </summary>
        /// <returns>插入成功返回true，失败返回false</returns>
        public bool insert(JS_role _jsRole)
        {
            string sql = "insert into JS2 (JSM) values (@jsm)";
            SqlParameter[] sqlPar = { new SqlParameter("@jsm", _jsRole.Jsm) };
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql, sqlPar) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }


        /// <summary>
        /// 更新角色JS实体
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool update(JS_role _jsRole)
        {

            string sql = "update JS2 SET jsm=@jsm where JSBH=@jsbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@jsbh", _jsRole.Jsbh),
                                         new SqlParameter("@jsm", _jsRole.Jsm) 
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
        /// 获取全部角色信息
        /// </summary>
        /// <returns>返回数据库中所有的角色信息</returns>
        public JS_role[] getAll()
        {

            string sql = "select * from JS2";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JS_role> list = new List<JS_role>();
            while (reader.Read())
            {
                list.Add(new JS_role((int)reader["jsbh"], (string)reader["jsm"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的角色名称。如果返回的角色JS对象的njbh字段是-1表明数据库中不存在指定的角色信息
        /// </summary>
        public JS_role getJSRoleById(int _jsbh)
        {

            string sql = "select * from JS2 where jsbh=@jsbh";
            SqlParameter[] sqlPars = { new SqlParameter("@jsbh", _jsbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            JS_role jsRole = new JS_role();
            if (reader.Read())
            {
                jsRole.Jsbh = (int)reader["jsbh"];
                jsRole.Jsm = (string)reader["jsm"];
            }
            dbCon.closeDbCon();
            return jsRole;
        }
    }
}