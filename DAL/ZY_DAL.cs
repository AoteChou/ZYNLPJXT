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
    /// 专业 数据访问层
    /// </summary>
    public class ZY_DAL
    {

        /// <summary>
        /// 获取专业信息
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <returns>专业</returns>
        public ZY getZY(int zybh) {
            string sqlString = "select * from zy where zybh=@zybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh)
                           };

            ZY zy = new ZY();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zy.Zybh = zybh;
                zy.Xkbh = (int)(sdReader["xkbh"]);
                zy.Zym = (string)(sdReader["zym"]);
                zy.Zyfzr = (string)(sdReader["zyfzr"]);

            }
            dbConnection.closeDbCon();
            return zy;
        }
        /// <summary>
        /// 插入专业
        /// </summary>
        /// <param name="zy">专业实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertZY(ZY zy)
        {

            String sqlString = "insert into ZY (XKBH,ZYM,ZYFZR) values (@xkbh,@zym,@zyfzr)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@xkbh",zy.Xkbh),
                new SqlParameter("@zym",zy.Zym),
                new SqlParameter("@zyfzr",zy.Zyfzr)
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
        /// 删除专业
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteZY(int zybh)
        {

            string sqlString = "delete from ZY where zybh=@zybh";
            SqlParameter[] sqlParameters = { 
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
        /// 更新专业
        /// </summary>
        /// <param name="zy">专业实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateZY(ZY zy)
        {

            String sqlString = "update ZY set xkbh=@xkbh,zym=@zym,zyfzr=@zyfzr where zybh=@zybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xkbh",zy.Xkbh),
                new SqlParameter("@zym",zy.Zym),
                new SqlParameter("@zyfzr",zy.Zyfzr),
                new SqlParameter("@zybh",zy.Zybh)
               
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