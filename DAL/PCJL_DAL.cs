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
    /// 评测记录 数据访问层
    /// </summary>
    public class PCJL_DAL
    {
        /// <summary>
        /// 获取评测记录
        /// </summary>
        /// <param name="pcjlbh">评测记录编号</param>
        /// <returns>评测记录</returns>
        public PCJL getPCJL(int pcjlbh)
        {
            string sqlString = "select * from pcjl where pcjlbh=@pcjlbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@pcjlbh",pcjlbh)
                           };

            PCJL pcjl = new PCJL();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                pcjl.Pcjlbh = pcjlbh;
                pcjl.Stbh=(int)(sdReader["stbh"]);
                pcjl.Xsbh=(string)(sdReader["xsbh"]);
                pcjl.Xzrq = (DateTime)(sdReader["xzrq"]);
                pcjl.Scrq = (DateTime)(sdReader["scrq"]);
                pcjl.Pcfs = (int)(sdReader["pcfs"]);
                pcjl.Gtr = (string)(sdReader["gtr"]);
                pcjl.Xsstda = (string)(sdReader["xsstda"]);

            }
            dbConnection.closeDbCon();
            return pcjl;
        }
        /// <summary>
        /// 插入评测记录
        /// </summary>
        /// <param name="pcjl">评测记录实体</param>
        /// <returns>是否插入成功</returns>
        public bool insertPCJL(PCJL pcjl)
        {

            String sqlString = "insert into PCJL (STBH,XSBH,XZRQ,SCRQ,PCFS,GTR,XSSTDA) values (@stbh,@xsbh,@xzrq,@scrq,@pcfs,@gtr,@xsstda)";
            

            SqlParameter[] sqlParameters ={
                new SqlParameter("@stbh",pcjl.Stbh),
                new SqlParameter("@xsbh",pcjl.Xsbh),
                new SqlParameter("@xzrq",pcjl.Xzrq),
                new SqlParameter("@scrq",pcjl.Scrq),
                new SqlParameter("@pcfs",pcjl.Pcfs),
                new SqlParameter("@gtr",pcjl.Gtr==""?(object)DBNull.Value:pcjl.Gtr),
                 new SqlParameter("@xsstda",pcjl.Xsstda)
                
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
        /// 删除评测记录
        /// </summary>
        /// <param name="pcjlbh">评测记录编号</param>
        /// <returns>是否删除成功</returns>
        public bool deletePCJL(int pcjlbh)
        {

            string sqlString = "delete from PCJL where pcjlbh=@pcjlbh";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@pcjlbh",pcjlbh)
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
        /// 更新评测记录
        /// </summary>
        /// <param name="pcjl">评测记录实体</param>
        /// <returns>是否更新成功</returns>
        public bool updatePCJL(PCJL pcjl)
        {

            String sqlString = "update PCJL set stbh=@stbh,xsbh=@xsbh,xzrq=@xzrq,scrq=@scrq,pcfs=@pcfs,gtr=@gtr,xsstda=@xsstda where pcjlbh=@pcjlbh";
           
            SqlParameter[] sqlparameters ={
                new SqlParameter("@stbh",pcjl.Stbh),
                new SqlParameter("@xsbh",pcjl.Xsbh),
                new SqlParameter("@xzrq",pcjl.Xzrq),
                new SqlParameter("@scrq",pcjl.Scrq),
                new SqlParameter("@pcfs",pcjl.Pcfs),
                new SqlParameter("@gtr",pcjl.Gtr==""?(object)DBNull.Value:pcjl.Gtr),
                new SqlParameter("@pcjlbh",pcjl.Pcjlbh),
                new SqlParameter("@xsstda",pcjl.Xsstda)
            };
            
            
            DbConnection dbConnection = new DbConnection();
            try
            {
                dbConnection.executeNonQuery(sqlString, sqlparameters);
            }
            catch (Exception )
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