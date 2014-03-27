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
    /// 学院 数据访问层
    /// </summary>
    public class XY_DAL
    {
        /// <summary>
        /// 获取学院
        /// </summary>
        /// <param name="xybh">学院编号</param>
        /// <returns>学院</returns>
        public XY getXY(int xybh)
        {
            string sqlString = "select * from xy where xybh=@xybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xybh",xybh)
                           };

            XY xy = new XY();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                xy.Xybh = xybh;
                xy.Xymc = (string)(sdReader["xymc"]);

            }
            dbConnection.closeDbCon();
            return xy;
        }
        /// <summary>
        /// 插入学院
        /// </summary>
        /// <param name="xy">学院实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertXY(XY xy)
        {

            String sqlString = "insert into XY (XYMC) values (@xymc)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@xymc",xy.Xymc)
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
        /// 删除学院
        /// </summary>
        /// <param name="xybh">学院编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteXY(int xybh)
        {

            string sqlString = "delete from XY where xybh=@xybh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@xybh",xybh)
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
        /// 更新学院
        /// </summary>
        /// <param name="xy">学院实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateXY(XY xy)
        {

            String sqlString = "update XY set xymc=@xymc where xybh=@xybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xymc",xy.Xymc),
                new SqlParameter("@xybh",xy.Xybh)           
               
                           };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlparameters);
            }
            catch (Exception)
            {
                //System.Diagnostics.Debug.WriteLine("exception:   " + ex.ToString());
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