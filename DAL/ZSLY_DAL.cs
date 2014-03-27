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
    /// 知识领域 数据访问层
    /// </summary>
    public class ZSLY_DAL
    {
        /// <summary>
        /// 获取知识领域
        /// </summary>
        /// <param name="zslybh">知识领域编号</param>
        /// <returns>知识领域</returns>
        public ZSLY getZSLY(int zslybh)
        {
            string sqlString = "select * from zsly where zslybh=@zslybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zslybh",zslybh)
                           };

            ZSLY zsly = new ZSLY();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zsly.Zslybh = zslybh;
                zsly.Zslymc = (string)(sdReader["zslymc"]);
                zsly.Bz = (string)(sdReader["bz"]);

            }
            dbConnection.closeDbCon();
            return zsly;
        }
        /// <summary>
        /// 插入知识领域
        /// </summary>
        /// <param name="zsly">知识领域实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertZSLY(ZSLY zsly)
        {

            String sqlString = "insert into ZSLY (ZSLYMC,BZ) values (@zslymc,@bz)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@zslymc",zsly.Zslymc),
                new SqlParameter("@bz",zsly.Bz)
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
        /// 删除知识领域
        /// </summary>
        /// <param name="zslybh">知识领域编号</param>
        /// <returns>删除是否成功</returns>
        public bool deleteZSLY(int zslybh)
        {

            string sqlString = "delete from ZSLY where zslybh=@zslybh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@zslybh",zslybh)
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
        /// 更新知识领域
        /// </summary>
        /// <param name="zsly">知识领域</param>
        /// <returns>是否更新成功</returns>
        public bool updateZSLY(ZSLY zsly)
        {

            String sqlString = "update ZSLY set zslymc=@zslymc,bz=@bz where zslybh=@zslybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zslymc",zsly.Zslymc),
                new SqlParameter("@bz",zsly.Bz),
                new SqlParameter("@zslybh",zsly.Zslybh)
               
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