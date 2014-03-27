using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 专业课程 数据访问层
    /// </summary>
    public class ZYKC_DAL 
    {
        /// <summary>
        /// 获取专业课程
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>专业课程</returns>
        public ZYKC getZYKCbyZYBHandKCBH(int zybh, int kcbh){

            string sqlString="select * from zykc where zybh=@zybh and kcbh=@kcbh";
            SqlParameter[] sqlparameters=
            {
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@kcbh",kcbh)
                           };

            ZYKC zykc = new ZYKC();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read()) {
                zykc.Kcbh = (int)(sdReader["kcbh"]);
                zykc.Kcxzbh = (int)(sdReader["kcxzbh"]);
                zykc.Kkxq = (int)(sdReader["kkxq"]);
                zykc.Llxf = (decimal)(sdReader["llxf"]);
                zykc.Sjxf = (decimal)(sdReader["sjxf"]);
                zykc.Zybh = (int)(sdReader["zybh"]);
              
            }
            dbConnection.closeDbCon();
            return zykc;
        }
        /// <summary>
        /// 插入专业课程
        /// </summary>
        /// <param name="zykc">专业课程实体类</param>
        /// <returns>是否插入成功</returns>
        public bool insertZYKC(ZYKC zykc) {

            string sqlString = "insert into ZYKC (KCBH,ZYBH,KCXZBH,KKXQ,LLXF,SJXF) values (@kcbh,@zybh,@kcxzbh,@kkxq,@llxf,@sjxf)";
            SqlParameter[] sqlparameters = 
            {
                new SqlParameter("@kcbh",zykc.Kcbh),
                new SqlParameter("@zybh",zykc.Zybh),
                new SqlParameter("@kcxzbh",zykc.Kcxzbh),
                new SqlParameter("@kkxq",zykc.Kkxq),
                new SqlParameter("@llxf",zykc.Llxf),
                new SqlParameter("@sjxf",zykc.Sjxf)
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
            finally {
                dbConnection.closeDbCon();
            }
            
            

            return true;
        }
        /// <summary>
        /// 删除专业课程
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteZYKC(int zybh, int kcbh)
        {

            String sqlString = "delete from zykc where zybh=@zybh and kcbh=@kcbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@kcbh",kcbh)
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
        /// <summary>
        /// 更新专业课程的内容
        /// </summary>
        /// <param name="zykc">专业课程实体</param>
        /// <returns>是否更新成功</returns>
        public bool updateZYKC(ZYKC zykc) {

            String sqlString = "update zykc set kcxzbh=@kcxzbh,kkxq=@kkxq,llxf=@llxf,sjxf=@sjxf where zybh=@zybh and kcbh=@kcbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@kcbh",zykc.Kcbh),
                new SqlParameter("@zybh",zykc.Zybh),
                new SqlParameter("@kcxzbh",zykc.Kcxzbh),
                new SqlParameter("@kkxq",zykc.Kkxq),
                new SqlParameter("@llxf",zykc.Llxf),
                new SqlParameter("@sjxf",zykc.Sjxf)
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