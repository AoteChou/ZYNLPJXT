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
    /// 学科 数据访问层
    /// </summary>
    public class XK_DAL
    {
        /// <summary>
        /// 获取学科
        /// </summary>
        /// <param name="xkbh">学科编号</param>
        /// <returns>学科</returns>
        public XK getXK(int xkbh)
        {
            string sqlString = "select * from xk where xkbh=@xkbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xkbh",xkbh)
                           };

            XK xk = new XK();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                xk.Xkbh = xkbh;
                xk.Xkmc = (string)(sdReader["xkmc"]);
                xk.Xybh = (int)(sdReader["xybh"]);
                xk.Xkfzr = (string)(sdReader["xkfzr"]);

            }
            dbConnection.closeDbCon();
            return xk;
        }
        /// <summary>
        /// 查询学科下的学科负责人
        /// </summary>
        /// <param name="xkbh">学科编号</param>
        /// <returns>教师编号</returns>
        public string getJSbyXK(int xkbh)
        {
            string sqlString = "select xkfzr from xk where xkbh=@xkbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xkbh",xkbh)
                           };

            string xkfzr = "";

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                xkfzr = (string)(sdReader[0]);

            }
            dbConnection.closeDbCon();
            return xkfzr;
        }
        /// <summary>
        /// 查询教师负责的学科
        /// </summary>
        /// <param name="xkfzr">教师编号</param>
        /// <returns>学科编号数组</returns>
        public int[] getXKbyJS(string xkfzr)
        {
            string sqlString = "select xkbh from xk where xkfzr=@xkfzr";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xkfzr",xkfzr)
                           };

            List<int> xkbh = new List<int>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                xkbh.Add((int)(sdReader[0]));

            }
            dbConnection.closeDbCon();
            return xkbh.ToArray();
        }
        /// <summary>
        /// 插入学科
        /// </summary>
        /// <param name="xk">学科实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertXK(XK xk)
        {

            String sqlString = "insert into XK (XYBH,XKFZR,XKMC) values (@xybh,@xkfzr,@xkmc)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@xybh",xk.Xybh),
                new SqlParameter("@xkfzr",xk.Xkfzr==""?(object)DBNull.Value:xk.Xkfzr),
                new SqlParameter("@xkmc",xk.Xkmc)
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
        /// 删除学科
        /// </summary>
        /// <param name="xkbh">学科编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteXK(int xkbh)
        {

            string sqlString = "delete from XK where xkbh=@xkbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@xkbh",xkbh)
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
        /// 更新学科
        /// </summary>
        /// <param name="xk">学科实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateXK(XK xk)
        {

            String sqlString = "update XK set xybh=@xybh,xkfzr=@xkfzr,xkmc=@xkmc where xkbh=@xkbh";
            SqlParameter[] sqlparameters =
            {
                 new SqlParameter("@xybh",xk.Xybh),
                new SqlParameter("@xkfzr",xk.Xkfzr==""?(object)DBNull.Value:xk.Xkfzr),
                new SqlParameter("@xkmc",xk.Xkmc),
                new SqlParameter("@xkbh",xk.Xkbh)
               
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