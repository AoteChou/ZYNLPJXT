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
    /// 学生 数据访问层
    /// </summary>
    public class XS_DAL
    {
        /// <summary>
        /// 获取学生
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <returns>学生实体</returns>
        public XS getXS(string xsbh)
        {
            string sqlString = "select * from xs where xsbh=@xsbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh)
                           };

            XS xs = new XS();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                xs.Xsbh = xsbh;
                xs.Bjbh = (int)(sdReader["bjbh"]);
                xs.Rxnf = (DateTime)(sdReader["rxnf"]);

            }
            dbConnection.closeDbCon();
            return xs;
        }
        /// <summary>
        /// 插入学生
        /// </summary>
        /// <param name="xs">学生实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertXS(XS xs)
        {

            String sqlString = "insert into XS (BJBH,XSBH,RXNF) values (@bjbh,@xsbh,@rxnf)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@bjbh",xs.Bjbh),
                new SqlParameter("@xsbh",xs.Xsbh),
                new SqlParameter("@rxnf",xs.Rxnf)
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
        /// 删除学生
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteXS(string xsbh)
        {

            string sqlString = "delete from XS where xsbh=@xsbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@xsbh",xsbh)
                                           };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlParameters);
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
        /// <summary>
        /// 更新学生
        /// </summary>
        /// <param name="xs">学生实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateXS(XS xs)
        {

            String sqlString = "update XS set bjbh=@bjbh,rxnf=@rxnf where xsbh=@xsbh";
            SqlParameter[] sqlparameters =
            {
               new SqlParameter("@bjbh",xs.Bjbh),
               new SqlParameter("@rxnf",xs.Rxnf),
               new SqlParameter("@xsbh",xs.Xsbh)
                
               
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