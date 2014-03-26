using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    //课程知识单元 数据访问层
    public class KCZSDY_DAL
    {
        /// <summary>
        ///插入课程知识单元实体 
        /// </summary>
        public bool insert(KCZSDY _kczsdy)
        {
            string sql = "insert into KCZSDY (kcbh,zslybh,zsdybh) values (@kcbh,@zslybh,@zsdybh)";
            SqlParameter[] sqlPar = { new SqlParameter("@kcbh", _kczsdy.Kcbh),
                                       new SqlParameter("@zslybh",_kczsdy.Zslybh),
                                       new SqlParameter("@zsdybh",_kczsdy.Zsdybh)
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
        /// 删除课程知识单元实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(KCZSDY _kczsdy)
        {
            string sql = "delete from KCZSDY where kcbh=@kcbh and zslybh=@zslybh and zsdybh=@zsdybh ";
            SqlParameter[] sqlPars = { new SqlParameter("@kcbh", _kczsdy.Kcbh),
                                       new SqlParameter("@zslybh",_kczsdy.Zslybh),
                                       new SqlParameter("@zsdybh",_kczsdy.Zsdybh)
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
        /// 获取全部课程知识单元实体信息
        /// </summary>
        /// <returns>返回数据库中所有的课程知识单元实体信息</returns>
        public KCZSDY[] getAll()
        {
            string sql = "select * from KCZSDY";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<KCZSDY> list = new List<KCZSDY>();
            while (reader.Read())
            {
                list.Add(new KCZSDY((int)reader["kcbh"], (int)reader["zsdybh"], (int)reader["zslybh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}