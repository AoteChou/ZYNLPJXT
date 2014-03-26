using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Utility;
using ZYNLPJXT.Entity;

namespace ZYNLPJXT.DAL
{
    //课程性质 访问层
    public class KCXZ_DAL
    {
        /// <summary>
        ///插入课程性质实体 
        /// </summary>
        /// <returns>插入成功返回true，失败返回false</returns>
        public bool insert(KCXZ _kcxz)
        {
            string sql = "insert into KCXZ (kcxzmc) values (@kcxzmc)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcxzmc", _kcxz.Kcxzmc) };
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
        /// 更新课程性质实体
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool update(KCXZ _kcxz)
        {

            string sql = "update KCXZ SET kcxzmc=@kcxzmc where kcxzbh=@kcxzbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@kcxzmc", _kcxz.Kcxzmc), 
                                         new SqlParameter("@kcxzbh", _kcxz.Kcxzbh) };
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
        /// 删除课程性质实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(KCXZ _kcxz) {
            string sql = "delete from KCXZ where kcxzbh=@kcxzbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@kcxzbh", _kcxz.Kcxzbh)};
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
        /// 获取全部课程性质信息
        /// </summary>
        /// <returns>返回数据库中所有的课程性质信息</returns>
        public KCXZ[] getAll()
        {

            string sql = "select * from KCXZ";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<KCXZ> list = new List<KCXZ>();
            while (reader.Read())
            {
                list.Add(new KCXZ((int)reader["kcxzbh"], (string)reader["kcxzmc"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的课程性质。如果返回的课程性质对象的kcxzbh字段是-1表明数据库中不存在指定的课程性质信息
        /// </summary>
        public KCXZ getKCXZById(int _kcxzbh)
        {

            string sql = "select * from KCXZ where kcxzbh=@kcxzbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcxzbh", _kcxzbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            KCXZ kcxz = new KCXZ();
            if (reader.Read())
            {
                kcxz.Kcxzbh = (int)reader["kcxzbh"];
                kcxz.Kcxzmc = (string)reader["kcxzmc"];
            }
            dbCon.closeDbCon();
            return kcxz;
        }

    }
}