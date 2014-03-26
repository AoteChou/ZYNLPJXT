using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //测评记录 数据访问层
    public class CPJD_DAL
    {
        /// <summary>
        ///插入测评阶段CPJD实体 
        /// </summary>
        public bool insert(CPJD _cpjd)
        {
            string sql = "insert into CPJD (njbh,zybh,jdmc,qsxq,jzxq,cpjdjj) values (@njbh,@zybh,@jdmc,@qsxq,@jzxq,@cpjdjj)";
            SqlParameter[] sqlPar = { new SqlParameter("@njbh", _cpjd.Njbh),
                                       new SqlParameter("@zybh",_cpjd.Zybh),
                                       new SqlParameter("@jdmc",_cpjd.Jdmc),
                                       new SqlParameter("@qsxq",_cpjd.Qsxq),
                                       new SqlParameter("@jzxq",_cpjd.Jzxq),
                                       new SqlParameter("@cpjdjj",_cpjd.Cpjdjj)
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
        /// 更新测评阶段CPJD实体
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool update(CPJD _cpjd)
        {

            string sql = "update CPJD SET jdmc=@jdmc, qsxq=@qsxq, jzxq=@jzxq, cpjdjj=@cpjdjj where njbh=@njbh and jdbh=@jdbh and zybh=@zybh ";
            SqlParameter[] sqlPars = { new SqlParameter("@jdmc", _cpjd.Jdmc),
                                         new SqlParameter("@qsxq",_cpjd.Qsxq ),
                                         new SqlParameter("@jzxq",_cpjd.Jzxq),
                                         new SqlParameter("@cpjdjj",_cpjd.Cpjdjj),
                                         new SqlParameter("@njbh",_cpjd.Njbh),
                                         new SqlParameter("@jdbh",_cpjd.Jdbh),
                                         new SqlParameter("@zybh",_cpjd.Zybh),
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
        /// 删除测评阶段CPJD实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(CPJD _cpjd)
        {

            string sql = "delete from CPJD where njbh=@njbh and jdbh=@jdbh and zybh=@zybh ";
            SqlParameter[] sqlPars = {  new SqlParameter("@njbh",_cpjd.Njbh),
                                         new SqlParameter("@jdbh",_cpjd.Jdbh),
                                         new SqlParameter("@zybh",_cpjd.Zybh),
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
        /// 获取全部测评阶段信息
        /// </summary>
        /// <returns>返回数据库中所有的测评阶段信息</returns>
        public CPJD[] getAll()
        {
            string sql = "select * from CPJD";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<CPJD> list = new List<CPJD>();
            while (reader.Read())
            {
                list.Add(new CPJD((int)reader["jdbh"],(int)reader["njbh"],(int)reader["zybh"],(string)reader["jdmc"],(int)reader["qsxq"],(int)reader["jzxq"],(string)reader["cpjdjj"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的测评阶段信息。
        /// </summary>
        public CPJD getCPJDById(int _jdbh,int _njbh,int _zybh)
        {

            string sql = "select * from CPJD where njbh=@njbh and jdbh=@jdbh and zybh=@zybh";
            SqlParameter[] sqlPars = { new SqlParameter("@njbh", _njbh),
                                         new SqlParameter("@jdbh",_jdbh),
                                         new SqlParameter("@zybh",_zybh)
                                     };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            CPJD cpjd = new CPJD();
            if (reader.Read())
            {
                cpjd.Njbh= (int)reader["njbh"];
                cpjd.Jdbh=(int)reader["jdbh"];
                cpjd.Zybh=(int)reader["zybh"];
                cpjd.Jdmc = (string)reader["jdmc"];
                cpjd.Qsxq = (int)reader["qsxq"];
                cpjd.Jzxq = (int)reader["jzxq"];
                cpjd.Cpjdjj=(string)reader["cpjdjj"];
            }
            dbCon.closeDbCon();
            return cpjd;
        }
    }
}