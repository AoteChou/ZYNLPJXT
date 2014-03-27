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
    /// 用户角色表 数据访问层
    /// </summary>
    public class YHJSB_DAL
    {
     
        /// <summary>
        /// 插入用户角色表
        /// </summary>
        /// <param name="yhjsb">用户角色表实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertYHJSB(YHJSB yhjsb)
        {

            String sqlString = "insert into YHJSB (YHBH,JSBH) values (@yhbh,@jsbh)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@yhbh",yhjsb.Yhbh),
                new SqlParameter("@jsbh",yhjsb.Jsbh)
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
        /// 删除用户角色
        /// </summary>
        /// <param name="yhbh">用户编号</param>
        /// <param name="jsbh">角色编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteYHJSB(string yhbh,int jsbh)
        {

            string sqlString = "delete from YHJSB where yhbh=@yhbh and jsbh=@jsbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@yhbh",yhbh),
                new SqlParameter("@jsbh",jsbh)
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