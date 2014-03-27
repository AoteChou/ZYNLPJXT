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
    /// 专业二级指标 数据访问层
    /// </summary>
    public class ZYEJZB_DAL
    {
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="zyejzb">专业二级指标实体</param>
        /// <returns>是否成功插入</returns>
        public bool insertZYEJZB(ZYEJZB zyejzb) {

            String sqlString ="insert into ZYEJZB (EJZBBH,ZYBH,NLYQ) values (@ejzbbh,@zybh,@nlyq)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@ejzbbh",zyejzb.Ejzbbh),
                new SqlParameter("@zybh",zyejzb.Zybh),
                new SqlParameter("@nlyq",zyejzb.Nlyq)
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
            finally {
                dbConnection.closeDbCon();
            }
            
            return true;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ejzbbh">二级指标编号</param>
        /// <param name="zybh">专业编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteZYEJZB(int ejzbbh,int zybh) {

            string sqlString = "delete from ZYEJZB where ejzbbh=@ejzbbh and zybh=@zybh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@ejzbbh",ejzbbh),
                new SqlParameter("@zybh",zybh)
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
        /// 更新专业二级指标
        /// </summary>
        /// <param name="zyejzb">专业二级指标类</param>
        /// <returns>是否更新成功</returns>
        public bool updateZYEJZB(ZYEJZB zyejzb)
        {

            String sqlString = "update ZYEJZB set ejzbbh=@ejzbbh,zybh=@zybh,nlyq=@nlyq where ejzbbh=@ejzbbh and zybh=@zybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@ejzbbh",zyejzb.Ejzbbh),
                new SqlParameter("@zybh",zyejzb.Zybh),
                new SqlParameter("@nlyq",zyejzb.Nlyq)
               
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