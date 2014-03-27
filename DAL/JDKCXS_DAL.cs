using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //阶段课程学生 数据访问层
    public class JDKCXS_DAL
    {
        /// <summary>
        ///插入阶段课程学生课程实体 
        /// </summary>
        public bool insert(JDKCXS _jdkcxs)
        {
            string sql = "insert into JDKCXS (kcbh,zybh,njbh,jdbh,xsbh,jsbh) values (@kcbh,@zybh,@njbh,@jdbh,@xsbh,@jsbh)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _jdkcxs.Kcbh),
                                       new SqlParameter("@zybh",_jdkcxs.Zybh),
                                       new SqlParameter("@njbh",_jdkcxs.Njbh),
                                       new SqlParameter("@jdbh",_jdkcxs.Jdbh),
                                       new SqlParameter("@xsbh",_jdkcxs.Xsbh),
                                       new SqlParameter("@jsbh",_jdkcxs.Jsbh)
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
        /// 删除阶段课程学生实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(JDKCXS _jdkcxs)
        {
            string sql = "delete from JDKCXS where kcbh=@kcbh and zybh=@zybh and njbh=@njbh and jdbh=@jdbh and xsbh=@xsbh and jsbh=@jsbh";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _jdkcxs.Kcbh),
                                         new SqlParameter("@zybh", _jdkcxs.Zybh),
                                         new SqlParameter("@njbh",_jdkcxs.Njbh),
                                         new SqlParameter("@jdbh",_jdkcxs.Jdbh),
                                         new SqlParameter("@xsbh",_jdkcxs.Xsbh),
                                         new SqlParameter("@jsbh",_jdkcxs.Jsbh)
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
        public JDKCXS[] getAll()
        {
            string sql = "select * from JDKCXS";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JDKCXS> list = new List<JDKCXS>();
            while (reader.Read())
            {
                list.Add(new JDKCXS((int)reader["kcbh"], (int)reader["zybh"], (int)reader["jdbh"], (int)reader["njbh"],(string)reader["xsbh"],(string)reader["jsbh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}