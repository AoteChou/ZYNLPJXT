using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //阶段课程 数据访问层
    public class JDKC_DAL
    {
        /// <summary>
        ///插入阶段课程课程实体 
        /// </summary>
        public bool insert(JDKC _jdkc)
        {
            string sql = "insert into JDKC (kcbh,zybh,njbh,jdbh) values (@kcbh,@zybh,@njbh,@jdbh)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _jdkc.Kcbh),
                                       new SqlParameter("@zybh",_jdkc.Zybh),
                                       new SqlParameter("@njbh",_jdkc.Njbh),
                                       new SqlParameter("@jdbh",_jdkc.Jdbh)
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
        /// 删除阶段课程实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(JDKC _jdkc)
        {
            string sql = "delete from JDKC where kcbh=@kcbh and zybh=@zybh and njbh=@njbh and jdbh=@jdbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _jdkc.Kcbh),
                                         new SqlParameter("@zybh", _jdkc.Zybh),
                                         new SqlParameter("@njbh",_jdkc.Njbh),
                                         new SqlParameter("@jdbh",_jdkc.Jdbh)
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
        /// 获取全部阶段课程信息
        /// </summary>
        /// <returns>返回数据库中所有的阶段课程信息</returns>
        public JDKC[] getAll()
        {
            string sql = "select * from JDKC";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JDKC> list = new List<JDKC>();
            while (reader.Read())
            {
                list.Add(new JDKC((int)reader["kcbh"], (int)reader["zybh"], (int)reader["jdbh"], (int)reader["njbh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}