using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 一级指标能力
    /// </summary>
    public class YJZB_DAL
    {
        /// <summary>
        /// 获取一级指标
        /// </summary>
        /// <param name="yjzbbh">一级指标编号</param>
        /// <returns>一级指标</returns>
        public YJZB getYJZB(int yjzbbh)
        {
            string sqlString = "select * from yjzb where yjzbbh=@yjzbbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yjzbbh",yjzbbh)
                           };

            YJZB yjzb = new YJZB();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                yjzb.Yjzbbh = yjzbbh;
                yjzb.Yjzbmc = (string)(sdReader["yjzbmc"]);
               

            }
            dbConnection.closeDbCon();
            return yjzb;
        }
        /// <summary>
        /// 插入一级指标
        /// </summary>
        /// <param name="yjzb">一级指标编号</param>
        /// <returns>是否插入成功</returns>
        public bool insertYJZB(YJZB yjzb)
        {

            String sqlString = "insert into YJZB (YJZBMC) values (@yjzbmc)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@yjzbmc",yjzb.Yjzbmc)
            };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlParameters);
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                dbConnection.closeDbCon();
            }

            return true;
        }
        /// <summary>
        /// 删除二级指标
        /// </summary>
        /// <param name="yjzbbh">二级指标编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteYJZB(int yjzbbh)
        {

            string sqlString = "delete from YJZB where yjzbbh=@yjzbbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@yjzbbh",yjzbbh)
                                           };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlParameters);
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                dbConnection.closeDbCon();
            }



            return true;

        }
        /// <summary>
        /// 更新一级指标
        /// </summary>
        /// <param name="yjzb">一级指标实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateYJZB(YJZB yjzb)
        {

            String sqlString = "update YJZB set yjzbmc=@yjzbmc where yjzbbh=@yjzbbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yjzbmc",yjzb.Yjzbmc),
                new SqlParameter("@yjzbbh",yjzb.Yjzbbh)
               
                           };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlparameters);
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                dbConnection.closeDbCon();
            }



            return true;
        }
    }
}