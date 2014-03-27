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
    /// 知识点 数据访问层
    /// </summary>
    public class ZSD_DAL
    {
        /// <summary>
        /// 获取知识点 
        /// </summary>
        /// <param name="zsdbh">知识点编号</param>
        /// <returns>知识点</returns>
        public ZSD getZSD(int zsdbh)
        {
            string sqlString = "select * from zsd where zsdbh=@zsdbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zsdbh",zsdbh)
                           };

            ZSD zsd = new ZSD();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zsd.Zsdbh = zsdbh;
                zsd.Zslybh = (int)(sdReader["zslybh"]);
                zsd.Zsdybh = (int)(sdReader["zsdybh"]);
                zsd.Zsdmc = (string)(sdReader["zsdmc"]);
                zsd.Bz = (string)(sdReader["bz"]);

            }
            dbConnection.closeDbCon();
            return zsd;
        }
        /// <summary>
        /// 插入知识点
        /// </summary>
        /// <param name="zsd">知识点实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertZSD(ZSD zsd)
        {

            String sqlString = "insert into ZSD (ZSLYBH,ZSDYBH,ZSDMC,BZ) values (@zslybh,@zsdybh,@zsdmc,@bz)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@zslybh",zsd.Zslybh),
                new SqlParameter("@zsdybh",zsd.Zsdybh),
                new SqlParameter("@zsdmc",zsd.Zsdmc),
                new SqlParameter("@bz",zsd.Bz)
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
        /// 删除知识点
        /// </summary>
        /// <param name="zsdbh">知识点编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteZSD(int zsdbh)
        {

            string sqlString = "delete from ZSD where zsdbh=@zsdbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@zsdbh",zsdbh)
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
        /// 更新知识点
        /// </summary>
        /// <param name="zsd">知识点实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateZSD(ZSD zsd)
        {

            String sqlString = "update ZSD set zslybh=@zslybh,zsdybh=@zsdybh,zsdmc=@zsdmc,bz=@bz where zsdbh=@zsdbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zslybh",zsd.Zslybh),
                new SqlParameter("@zsdybh",zsd.Zsdybh),
                new SqlParameter("@zsdmc",zsd.Zsdmc),
                new SqlParameter("@bz",zsd.Bz),
                new SqlParameter("@zsdbh",zsd.Zsdbh)
               
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