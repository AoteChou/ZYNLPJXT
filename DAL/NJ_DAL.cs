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
    /// 年级数据库访问层
    /// </summary>
    public class NJ_DAL
    {

        /// <summary>
        ///插入nj实体 
        /// </summary>
        /// <param name="nj"></param>
        /// <returns>插入成功返回true，失败返回false</returns>
        public bool insert(NJ nj)
        {
            string sql = "insert into NJ (NJMC) values (@njmc)";
            SqlParameter[] sqlPar = {new SqlParameter("@njmc", nj.Njmc)};
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql,sqlPar) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }


        /// <summary>
        /// 更新NJ实体
        /// </summary>
        /// <param name="nj"></param>
        /// <returns>是否更新成功</returns>
        public bool update(NJ nj) {

            string sql = "update NJ SET njmc=@njmc where njbh=@njbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@njmc",nj.Njmc),new SqlParameter("@njbh",nj.Njbh)};
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql,sqlPars) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }


        /// <summary>
        /// 获取全部年级信息
        /// </summary>
        /// <returns>返回数据库中所有的年级信息</returns>
        public NJ[] getAll() {

            string sql = "select * from NJ";
            DbConnection dbCon=new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<NJ> list = new List<NJ>();
            while (reader.Read()) {
                list.Add(new NJ((int)reader["njbh"],(string)reader["njmc"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的年级名称。如果返回的NJ对象的njbh字段是-1表明数据库中不存在指定的年级信息
        /// </summary>
        /// <param name="_njbh">年级编号</param>
        /// <returns>年级名称</returns>
        public NJ getNJById(int _njbh) {

            string sql = "select * from NJ where njbh=@njbh";
            SqlParameter[] sqlPars = { new SqlParameter("@njbh",_njbh)};
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            NJ nj = new NJ();
            if (reader.Read())
            {
                nj.Njbh = (int)reader["njbh"];
                nj.Njmc=(string)reader["njmc"];
            }
            dbCon.closeDbCon();
            return nj;
        }

    }
}