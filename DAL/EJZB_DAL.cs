using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Utility;
using ZYNLPJXT.Entity;

namespace ZYNLPJXT.DAL
{
    //二级指标 数据访问层
    public class EJZB_DAL
    {
        /// <summary>
        ///插入二级指标
        /// </summary>
        public bool insert(EJZB _ejzb)
        {
            string sql = "insert into EJZB (yjzbbh,ejzbmc) values (@yjzbbh,@ejzbmc)";
            SqlParameter[] sqlPar = { new SqlParameter("@yjzbbh", _ejzb.Yjzbbh),
                                       new SqlParameter("@ejzbmc",_ejzb.Ejzbmc)
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
        ///更新二级指标
        /// </summary>
        public bool update(EJZB _ejzb)
        {
            string sql = "update EJZB set ejzbmc=@ejzbmc where yjzbbh=@yjzbbh and ejzbbh=@ejzbbh";
            SqlParameter[] sqlPar = { new SqlParameter("@yjzbbh", _ejzb.Yjzbbh),
                                       new SqlParameter("@ejzbbh",_ejzb.Ejzbbh),
                                       new SqlParameter("@ejzbmc",_ejzb.Ejzbmc)
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
        ///更新二级指标
        /// </summary>
        public bool delete(EJZB _ejzb)
        {
            string sql = "delete from EJZB where yjzbbh=@yjzbbh and ejzbbh=@ejzbbh";
            SqlParameter[] sqlPar = { new SqlParameter("@yjzbbh", _ejzb.Yjzbbh),
                                       new SqlParameter("@ejzbbh",_ejzb.Ejzbbh)
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
        /// 获取给定一级指标下所有二级指标
        /// </summary>
        /// <returns>返回数据库中所有的角色信息</returns>
        public EJZB[] getAllByYizb(int _yjzbbh)
        {

            string sql = "select * from EJZB where yjzbbh=' "+_yjzbbh+"'";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<EJZB> list = new List<EJZB>();
            while (reader.Read())
            {
                list.Add(new EJZB((int)reader["yjzbbh"],(int)reader["ejzbbh"],(string)reader["ejzbmc"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的二级指标。如果返回的二级指标对象的字段是-1表明数据库中不存在指定的二级指标信息
        /// </summary>
        public EJZB getEJZBById(int _ejzbbh,int _yjzbbh)
        {

            string sql = "select * from EJZB where yjzbbh=@yjzbbh and ejzbbh=@ejzbbh";
            SqlParameter[] sqlPars = { new SqlParameter("@yjzbbh", _yjzbbh) ,
                                     new SqlParameter("@ejzbbh",_ejzbbh)};
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            EJZB ejzb = new EJZB();
            if (reader.Read())
            {
                ejzb.Yjzbbh= (int)reader["yjzbbh"];
                ejzb.Ejzbbh = (int)reader["ejzbbh"];
                ejzb.Ejzbmc = (string)reader["ejzbmc"];
            }
            dbCon.closeDbCon();
            return ejzb;
        }

    }
}