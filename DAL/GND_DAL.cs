using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using ZYNLPJXT.DAL;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 功能点 访问层
    /// </summary>
    public class GND_DAL
    {
        /// <summary>
        ///插入功能点GND实体 
        /// </summary>
        public bool insert(GND _gnd)
        {
            string sql = "insert into GND (gnm,gnlj,ssml) values (@gnm,@gnlj,@ssml)";
            SqlParameter[] sqlPar = { new SqlParameter("@gnm", _gnd.Gnm),
                                       new SqlParameter("@gnlj",_gnd.Gnlj),
                                       new SqlParameter("@ssml",_gnd.Ssml),
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
        /// 更新功能点GND实体
        /// </summary>
        /// <returns>是否更新成功</returns>
        public bool update(GND _gnd)
        {

            string sql = "update GND SET gnm=@gnm, gnlj=@gnlj, ssml=@ssml where gnbh=@gnbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@gnm", _gnd.Gnm),
                                         new SqlParameter("@gnlj", _gnd.Gnlj),
                                         new SqlParameter("@ssml",_gnd.Ssml),
                                         new SqlParameter("@gnbh",_gnd.Gnbh),
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
        /// 删除功能点实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(GND _gnd)
        {
            string sql = "delete from GND where gnbh=@gnbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@gnbh", _gnd.Gnbh) };
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
        /// 获取全部功能点信息
        /// </summary>
        /// <returns>返回数据库中所有的功能点信息</returns>
        public GND[] getAll()
        {
            string sql = "select * from GND";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<GND> list = new List<GND>();
            while (reader.Read())
            {
                list.Add(new GND((int)reader["gnbh"], (string)reader["gnm"],(string)reader["gnlj"],(string)reader["ssml"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

        /// <summary>
        /// 获取指定编号对应的功能点。
        /// </summary>
        public GND getGNDById(int _gnbh)
        {

            string sql = "select * from GND where gnbh=@gnbh";
            SqlParameter[] sqlPars = { new SqlParameter("@gnbh", _gnbh) };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql, sqlPars);
            GND gnd = new GND();
            if (reader.Read())
            {
                gnd.Gnbh = (int)reader["gnbh"];
                gnd.Gnm=(string)reader["gnm"];
                gnd.Gnlj=(string)reader["gnlj"];
                gnd.Ssml=(string)reader["ssml"];
            }
            dbCon.closeDbCon();
            return gnd;
        }
    }
}