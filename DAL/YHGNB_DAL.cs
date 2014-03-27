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
    /// 用户功能表 数据访问层
    /// </summary>
    public class YHGNB_DAL
    {
        /// <summary>
        /// 插入用户功能表
        /// </summary>
        /// <param name="yhgnb">用户功能表实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertYHGNB(YHGNB yhgnb)
        {

            String sqlString = "insert into YHGNB (GNBH,YHBH) values (@gnbh,@yhbh)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@gnbh",yhgnb.Gnbh),
                new SqlParameter("@yhbh",yhgnb.Yhbh)
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
       /// 删除用户功能表
       /// </summary>
       /// <param name="yhbh">用户编号</param>
       /// <param name="gnbh">功能编号</param>
       /// <returns>是否删除成功</returns>
        public bool deleteYHGNB(string yhbh, int gnbh)
        {

            string sqlString = "delete from YHGNB where yhbh=@yhbh and gnbh=@gnbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@yhbh",yhbh),
                new SqlParameter("@gnbh",gnbh)
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
    }
}