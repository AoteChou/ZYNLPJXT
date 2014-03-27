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
    /// 试题 数据访问层
    /// </summary>
    public class ST_DAL
    {
        /// <summary>
        /// 获取试题
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <returns>试题实体</returns>
        public ST getST(int stbh)
        {
            string sqlString = "select * from st where stbh=@stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@stbh",stbh)
                           };

            ST st = new ST();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                st.Stbh=stbh;
                st.Kcbh=(int)(sdReader["kcbh"]);
                st.Ctsj=(DateTime)(sdReader["ctsj"]);
                st.Tmnr=(string)(sdReader["tmnr"]);
                st.Tmda=(string)(sdReader["tmda"]);
                st.Ctr=(string)(sdReader["ctr"]);
                st.Sfzdyj=(Int16)(sdReader["sfzdyj"]);
                st.Sfsc=(Int16)(sdReader["sfsc"]);


            }
            dbConnection.closeDbCon();
            return st;
        }
        /// <summary>
        /// 插入试题
        /// </summary>
        /// <param name="st">试题</param>
        /// <returns>是否插入成功</returns>
        public bool insertST(ST st)
        {

            String sqlString = "insert into ST (KCBH,CTSJ,TMNR,TMDA,CTR,SFZDYJ,SFSC) values (@kcbh,@ctsj,@tmnr,@tmda,@ctr,@sfzdyj,@sfsc)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@kcbh",st.Kcbh),
                new SqlParameter("@ctsj",st.Ctsj),
                new SqlParameter("@tmnr",st.Tmnr),
                new SqlParameter("@tmda",st.Tmda),
                new SqlParameter("@ctr",st.Ctr),
                new SqlParameter("@sfzdyj",st.Sfzdyj),
                new SqlParameter("@sfsc",st.Sfsc)

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
        /// 删除试题
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <returns>是否成功删除</returns>
        public bool deleteST(int stbh)
        {

            string sqlString = "delete from ST where stbh=@stbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@stbh",stbh)
                                           };

            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlParameters);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("exp:   " + ex.ToString());
                return false;
            }
            finally
            {
                dbConnection.closeDbCon();
            }



            return true;

        }
        /// <summary>
        /// 更新试题
        /// </summary>
        /// <param name="st">试题实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateST(ST st)
        {

            String sqlString = "update ST set kcbh=@kcbh,ctsj=@ctsj,tmnr=@tmnr,tmda=@tmda,ctr=@ctr,sfzdyj=@sfzdyj,sfsc=@sfsc where stbh=@stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",st.Kcbh),
                new SqlParameter("@ctsj",st.Ctsj),
                new SqlParameter("@tmnr",st.Tmnr),
                new SqlParameter("@tmda",st.Tmda),
                new SqlParameter("@ctr",st.Ctr),
                new SqlParameter("@sfzdyj",st.Sfzdyj),
                new SqlParameter("@sfsc",st.Sfsc),
                new SqlParameter("@stbh",st.Stbh)
               
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