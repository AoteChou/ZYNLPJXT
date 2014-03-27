using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Utility;
using ZYNLPJXT.Entity;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //出题 数据库访问层
    public class CT_DAL
    {
        /// <summary>
        ///插入出题实体 
        /// </summary>
        public bool insert(CT _ct)
        {
            string sql = "insert into CT (kcbh,zybh,ctr) values (@kcbh,@zybh,@ctr)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _ct.Kcbh),
                                       new SqlParameter("@zybh",_ct.Zybh),
                                       new SqlParameter("@ctr",_ct.Ctr)
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
        /// 删除出题ct实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(CT _ct)
        {
            string sql = "delete from CT where kcbh=@kcbh and zybh=@zybh and ctr=@ctr";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _ct.Kcbh),
                                         new SqlParameter("@zybh", _ct.Zybh),
                                         new SqlParameter("@ctr",_ct.Ctr)
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
        /// 获取全部出题信息
        /// </summary>
        /// <returns>返回数据库中所有的出题信息</returns>
        public CT[] getAll()
        {
            string sql = "select * from CT";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<CT> list = new List<CT>();
            while (reader.Read())
            {
                list.Add(new CT((int)reader["kcbh"],(int)reader["zybh"],(string)reader["ctr"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}