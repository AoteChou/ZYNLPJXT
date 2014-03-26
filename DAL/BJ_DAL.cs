using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using System.Data.SqlClient;
using System.Data.Sql;
using ZYNLPJXT.Utility;


namespace ZYNLPJXT.DAL
{
    //班级 数据访问层
    public class BJ_DAL
    {
        /// <summary>
        /// 插入班级。逻辑层需要保证班级实体中不出现默认值,因为班级实体没有可空字段。
        /// </summary>
        /// <param name="jsTea"></param>
        /// <returns></returns>
        public bool insert(BJ bj)
        {

            string sql = "insert into BJ (njbh,zybh,bjmc,rxnf) values (@njbh,@zybh,@bjmc,@rxnf)";
            SqlParameter[] sqlPar = { new SqlParameter("@njbh",bj.Njbh),
                                    new SqlParameter("@zybh",bj.Zybh),
                                    new SqlParameter("@bjmc",bj.Bjmc),
                                    new SqlParameter("@rxnf",bj.Rxnf)
                                    };
            DbConnection dbCon = new DbConnection();
            bool executedResult = false;
            if (dbCon.executeNonQuery(sql, sqlPar) > 0)
                executedResult = true;
            else
                executedResult = false;
            dbCon.closeDbCon();
            return executedResult;
        }


        /// <summary>
        /// 更新班级实体。需要确保班级的主键不为默认字段。
        /// </summary>
        /// <returns></returns>
        public bool update(BJ bj)
        {

            string sql = "update BJ SET njbh=@njbh, zybh=@zybh, bjmc=@bjmc, rxnf=@rxnf where bjbh=@bjbh ";
            SqlParameter[] sqlPars = { 
                                         new SqlParameter("@njbh", bj.Njbh),
                                         new SqlParameter("@zybh", bj.Zybh),
                                         new SqlParameter("@bjmc", bj.Bjmc),
                                         new SqlParameter("@rxnf", bj.Rxnf),
                                         new SqlParameter("@bjbh", bj.Bjbh)
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
        /// 获取所有班级信息
        /// </summary>
        /// <returns></returns>
        public BJ[] getAll()
        {
            string sql = "select * from BJ";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<BJ> list = new List<BJ>();
            while (reader.Read())
            {
                list.Add(new BJ((int)reader["bjbh"],(string)reader["bjmc"],(int)reader["njbh"],(DateTime)reader["rxnf"],(int)reader["zybh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 根据班级编号获取指定班级的信息。如果没有查找到指定班级的信息，那么返回的实体的字段为默认值。即数字为-1，字符串为""
        /// </summary>
        public BJ getBJById(int _bjbh)
        {

            string sql = "select * from BJ where bjbh=@bjbh";
            SqlParameter[] sqlPars = { new SqlParameter("@bjbh", _bjbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            BJ bj = new BJ();
            if (reader.Read())
            {
                bj.Bjbh=(int)reader["bjbh"];
                bj.Bjmc = (string)reader["bjmc"];
                bj.Njbh = (int)reader["njbh"];
                bj.Rxnf=(DateTime)reader["rxnf"];
                bj.Zybh=(int)reader["zybh"];
            }
            dbCon.closeDbCon();
            return bj;
        }

    }
}