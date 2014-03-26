using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    //教师年级专业课程 数据库访问层
    public class JSNJZYKC_DAL
    {
        /// <summary>
        ///插入教师年级专业课程实体 
        /// </summary>
        public bool insert(JSNJZYKC _jsnjzykc)
        {
            string sql = "insert into JSNJZYKC (kcbh,zybh,njbh,jsbh) values (@kcbh,@zybh,@njbh,@jsbh)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _jsnjzykc.Kcbh),
                                       new SqlParameter("@zybh",_jsnjzykc.Zybh),
                                       new SqlParameter("@njbh",_jsnjzykc.Njbh),
                                       new SqlParameter("@jsbh",_jsnjzykc.Jsbh)
                                    };
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql, sqlPar) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }


        /// <summary>
        /// 删除教师年级专业课程实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(JSNJZYKC _jsnjzykc)
        {
            string sql = "delete from JSNJZYKC where kcbh=@kcbh and zybh=@zybh and njbh=@njbh and jsbh=@jsbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _jsnjzykc.Kcbh),
                                         new SqlParameter("@zybh", _jsnjzykc.Zybh),
                                         new SqlParameter("@njbh",_jsnjzykc.Njbh),
                                         new SqlParameter("@jsbh",_jsnjzykc.Jsbh)
                                     };
            DbConnection dbCon = new DbConnection();
            bool executeResult = false;
            if (dbCon.executeNonQuery(sql, sqlPars) > 0)
                executeResult = true;
            else
                executeResult = false;
            dbCon.closeDbCon();
            return executeResult;
        }


        /// <summary>
        /// 获取全部教师年级专业课程信息
        /// </summary>
        /// <returns>返回数据库中所有的教师年级专业课程信息</returns>
        public JSNJZYKC[] getAll()
        {
            string sql = "select * from JSNJZYKC";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JSNJZYKC> list = new List<JSNJZYKC>();
            while (reader.Read())
            {
                list.Add(new JSNJZYKC((string)reader["jsbh"],(int)reader["kcbh"], (int)reader["njbh"], (int)reader["zybh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}