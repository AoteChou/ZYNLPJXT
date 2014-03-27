
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
    /// 知识单元 数据访问层
    /// </summary>
    public class ZSDY_DAL
    {
        /// <summary>
        /// 获取知识单元
        /// </summary>
        /// <param name="zsdybh">知识单元编号</param>
        /// <returns>知识单元</returns>
        public ZSDY getZSDY(int zsdybh)
        {
            string sqlString = "select * from zsdy where zsdybh=@zsdybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zsdybh",zsdybh)
                           };

            ZSDY zsdy = new ZSDY();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zsdy.Zsdybh = zsdybh;
                zsdy.Zsdymc = (string)(sdReader["zsdymc"]);
                zsdy.Zslybh = (int)(sdReader["zslybh"]);
                zsdy.Bz = (string)(sdReader["bz"]);
                zsdy.Ejzbbh = (int)(sdReader["ejzbbh"]);

            }
            dbConnection.closeDbCon();
            return zsdy;
        }
        /// <summary>
        /// 插入知识单元
        /// </summary>
        /// <param name="zsdy">知识单元实体</param>
        /// <returns>插入是否成功</returns>
        public bool insertZSDY(ZSDY zsdy)
        {

            String sqlString = "insert into ZSDY (ZSLYBH,EJZBBH,ZSDYMC,BZ) values (@zslybh,@ejzbbh,@zsdymc,@bz)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@zslybh",zsdy.Zslybh),
                new SqlParameter("@ejzbbh",zsdy.Ejzbbh==-1?(object)DBNull.Value:zsdy.Ejzbbh),
                new SqlParameter("@zsdymc",zsdy.Zsdymc),
                new SqlParameter("@bz",zsdy.Bz)
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
        /// 删除知识单元
        /// </summary>
        /// <param name="zsdybh">知识单元编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteZSDY(int zsdybh)
        {

            string sqlString = "delete from ZSDY where zsdybh=@zsdybh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@zsdybh",zsdybh)
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
        /// 更新知识单元
        /// </summary>
        /// <param name="zsdy">知识单元实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateZSDY(ZSDY zsdy)
        {

            String sqlString = "update ZSDY set zslybh=@zslybh,ejzbbh=@ejzbbh,zsdymc=@zsdymc,bz=@bz where zsdybh=@zsdybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zslybh",zsdy.Zslybh),
                new SqlParameter("@ejzbbh",zsdy.Ejzbbh==-1?(object)DBNull.Value:zsdy.Ejzbbh),
                new SqlParameter("@zsdymc",zsdy.Zsdymc),
                new SqlParameter("@bz",zsdy.Bz),
                new SqlParameter("@zsdybh",zsdy.Zsdybh)
               
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