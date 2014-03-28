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
    /// 用户 数据访问层
    /// </summary>
    public class YH_DAL
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="yhbh">用户编号</param>
        /// <returns>用户</returns>
        public YH getYH(string yhbh)
        {
            string sqlString = "select * from yh where yhbh=@yhbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yhbh)
                           };

            YH yh = new YH();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                yh.Yhbh = yhbh;
                yh.Mm = (string)(sdReader["mm"]);
                yh.Xb = (Int16)(sdReader["xb"]);
                yh.Xm = (string)(sdReader["xm"]);

            }
            dbConnection.closeDbCon();
            return yh;
        }

        public bool isExist(YH yh) {
            string sql = "select * from yh where yhbh=@yhbh and mm=@mm";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yh.Yhbh),
                new SqlParameter("@mm",yh.Mm)
                           };
            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sql, sqlparameters);
            if (sdReader.Read())
            {
                dbConnection.closeDbCon();
                return true;
            }
            dbConnection.closeDbCon();
            return false;
        
        }

        /// <summary>
        /// 插入用户
        /// </summary>
        /// <param name="yh">用户实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertYH(YH yh)
        {

            String sqlString = "insert into YH (YHBH,MM,XM,XB) values (@yhbh,@mm,@xm,@xb)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@yhbh",yh.Yhbh),
                new SqlParameter("@mm",yh.Mm),
                new SqlParameter("@xm",yh.Xm),
                new SqlParameter("@xb",yh.Xb)
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
        /// 删除用户
        /// </summary>
        /// <param name="yhbh">用户编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteYH(string yhbh)
        {

            string sqlString = "delete from YH where yhbh=@yhbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@yhbh",yhbh)
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
        /// 更新用户
        /// </summary>
        /// <param name="yh">用户实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateYH(YH yh)
        {

            String sqlString = "update YH set mm=@mm,xm=@xm,xb=@xb where yhbh=@yhbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yh.Yhbh),
                new SqlParameter("@mm",yh.Mm),
                new SqlParameter("@xm",yh.Xm),
                new SqlParameter("@xb",yh.Xb)
               
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