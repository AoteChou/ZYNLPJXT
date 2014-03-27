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
    /// 试题知识点 数据访问层
    /// </summary>
    public class STZSDB_DAL
    {
       /// <summary>
       /// 插入试题知识点
       /// </summary>
       /// <param name="stzsdb">试题知识点表</param>
       /// <returns>是否插入成功</returns>
        public bool insertSTZSDB(STZSDB stzsdb)
        {

            String sqlString = "insert into STZSDB (ZSLYBH,ZSDYBH,ZSDBH,ZSDBZ,STBH) values (@zslybh,@zsdybh,@zsdbh,@zsdbz,@stbh)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@zslybh",stzsdb.Zslybh),
                new SqlParameter("@zsdybh",stzsdb.Zsdybh),
                new SqlParameter("@zsdbh",stzsdb.Zsdbh),
                new SqlParameter("@zsdbz",stzsdb.Zsdbz),
                new SqlParameter("@stbh",stzsdb.Stbh)
            };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlParameters);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("sasas:" + ex.ToString());
                return false;
            }
            finally
            {
                dbConnection.closeDbCon();
            }

            return true;
        }
        /// <summary>
        /// 删除试题知识点
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <param name="zsdbh">知识点编号</param>
        /// <returns>是否成功删除</returns>
        public bool deleteSTZSDB(int stbh,int zsdbh)
        {

            string sqlString = "delete from STZSDB where stbh=@stbh and zsdbh=@zsdbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@stbh",stbh),
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
        /// 更新试题知识点比重
        /// </summary>
        /// <param name="stzsdb">试题知识点实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateSTZSDB(STZSDB stzsdb)
        {

            String sqlString = "update STZSDB set zsdbz=@zsdbz where zsdbh=@zsdbh and stbh=@stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zsdbh",stzsdb.Zsdbh),
                new SqlParameter("@stbh",stzsdb.Stbh),
                new SqlParameter("@zsdbz",stzsdb.Zsdbz)
               
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