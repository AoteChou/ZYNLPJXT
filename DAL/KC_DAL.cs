using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Entity;
using ZYNLPJXT.DAL;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    //课程 数据访问层
    public class KC_DAL
    {
        /// <summary>
        ///插入课程实体 
        /// </summary>
        /// <returns>插入成功返回true，失败返回false</returns>
        public bool insert(KC _kc)
        {
            string sql = "insert into KC(KCJJ,KCMC,KCFZR) values (@kcjj,@kcmc,@kcfzr)";
            SqlParameter[] sqlPar = { 
                                      new SqlParameter("@kcjj",_kc.Kcjj),
                                      new SqlParameter("@kcmc",_kc.Kcmc),
                                      new SqlParameter("@kcfzr",((_kc.Kcfzr.Trim())==""?((Object)DBNull.Value):_kc.Kcfzr))
                                    };
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
        /// 更新课程实体
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool update(KC _kc)
        {
            string sql = "update KC SET kcmc=@kcmc, kcjj=@kcjj, kcfzr=@kcfzr where kcbh=@kcbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _kc.Kcbh),
                                      new SqlParameter("@kcjj",_kc.Kcjj),
                                      new SqlParameter("@kcmc",_kc.Kcmc),
                                      new SqlParameter("@kcfzr",((_kc.Kcfzr.Trim())==""?((Object)DBNull.Value):_kc.Kcfzr))
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
        /// 删除课程性质实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(KC _kc)
        {
            string sql = "delete from KC where kcbh=@kcbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _kc.Kcbh) };
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
        /// 获取全部课程信息
        /// </summary>
        /// <returns>返回数据库中所有的课程信息</returns>
        public KC[] getAll()
        {

            string sql = "select * from KC";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<KC> list = new List<KC>();
            while (reader.Read())
            {
                list.Add(new KC((int)reader["kcbh"], (string)reader["kcmc"],(string)reader["kcjj"],(reader["kcfzr"]==DBNull.Value?"":(string)reader["kcfzr"])));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的课程。如果返回的课程对象的kcbh字段是-1表明数据库中不存在指定的课程信息
        /// </summary>
        public KC getKCById(int _kcbh)
        {

            string sql = "select * from KC where kcbh=@kcbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _kcbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            KC kc = new KC();
            if (reader.Read())
            {
                kc.Kcbh = (int)reader["kcbh"];
                kc.Kcmc = (string)reader["kcmc"];
                kc.Kcjj=(string)reader["kcjj"];
                kc.Kcfzr=reader["kcfzr"]==DBNull.Value?"":(string)reader["kcfzr"];
            }
            dbCon.closeDbCon();
            return kc;
        }
    }
}