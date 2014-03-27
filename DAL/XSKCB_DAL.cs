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
    /// 学生课程表 数据访问层
    /// </summary>
    public class XSKCB_DAL
    {
       /// <summary>
       /// 插入学生课程表
       /// </summary>
       /// <param name="xskcb">学生课程表实体</param>
       /// <returns>是否插入成功</returns>
        public bool insertXSKCB(XSKCB xskcb)
        {

            String sqlString = "insert into XSKCB (KCBH,ZYBH,NJBH,JSBH,XSBH) values (@kcbh,@zybh,@njbh,@jsbh,@xsbh)";
            SqlParameter[] sqlParameters ={
                new SqlParameter("@kcbh",xskcb.Kcbh),
                new SqlParameter("@zybh",xskcb.Zybh),
                new SqlParameter("@njbh",xskcb.Njbh),
                new SqlParameter("@jsbh",xskcb.Jsbh),
                new SqlParameter("@xsbh",xskcb.Xsbh)

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
        /// 删除学生课程表
        /// </summary>
        /// <param name="kcbh">课程编号</param>
        /// <param name="zybh">专业编号</param>
        /// <param name="njbh">年级编号</param>
        /// <param name="jsbh">教师编号</param>
        /// <param name="xsbh">学生编号</param>
        /// <returns>是否删除成功</returns>
        public bool deleteXSKCB(int kcbh,int zybh,int njbh,string jsbh,string xsbh)
        {

            string sqlString = "delete from XSKCB where kcbh=@kcbh and zybh=@zybh and njbh=@njbh and jsbh=@jsbh and xsbh=@xsbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@kcbh",kcbh),
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@njbh",njbh),
                new SqlParameter("@jsbh",jsbh),
                new SqlParameter("@xsbh",xsbh)
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