using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //年级专业课程 数据库访问层
    public class NJZYKC_DAL
    {
        /// <summary>
        ///插入年级专业课程实体 
        /// </summary>
        public bool insert(NJZYKC _njzykc)
        {
            string sql = "insert into NJZYKC (kcbh,zybh,njbh) values (@kcbh,@zybh,@njbh)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _njzykc.Kcbh),
                                       new SqlParameter("@zybh",_njzykc.Zybh),
                                       new SqlParameter("@njbh",_njzykc.Njbh)
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
        /// 删除年级专业课程实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(NJZYKC _njzykc)
        {
            string sql = "delete from NJZYKC where kcbh=@kcbh and zybh=@zybh and njbh=@njbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _njzykc.Kcbh),
                                         new SqlParameter("@zybh", _njzykc.Zybh),
                                         new SqlParameter("@njbh",_njzykc.Njbh)
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
        /// 获取全部年级专业课程信息
        /// </summary>
        /// <returns>返回数据库中所有的年级专业课程信息</returns>
        public NJZYKC[] getAll()
        {
            string sql = "select * from NJZYKC";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<NJZYKC> list = new List<NJZYKC>();
            while (reader.Read())
            {
                list.Add(new NJZYKC((int)reader["kcbh"],(int)reader["njbh"],(int)reader["zybh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}