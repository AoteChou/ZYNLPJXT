using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.DAL;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //角色功能表 访问层
    public class JSGNB_DAL
    {
        /// <summary>
        ///插入角色功能点GND实体 
        /// </summary>
        public bool insert(JSGNB _jsgnd)
        {
            string sql = "insert into JSGNB (jsbh,gnbh) values (@jsbh,@gnbh)";
            SqlParameter[] sqlPar = { new SqlParameter("@jsbh", _jsgnd.Jsbh),
                                       new SqlParameter("@gnbh",_jsgnd.Gnbh),
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
        /// 删除角色功能点JSGND实体
        /// </summary>
        /// <returns>是否删除成功</returns>
        public bool delete(JSGNB _jsgnb)
        {

            string sql = "delete from JSGNB where jsbh=@jsbh and gnbh=@gnbh ";
            SqlParameter[] sqlPars = { new SqlParameter("@jsbh", _jsgnb.Jsbh),
                                         new SqlParameter("@gnbh", _jsgnb.Gnbh),
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
        /// 获取全部角色功能点信息
        /// </summary>
        /// <returns>返回数据库中所有的角色功能点信息</returns>
        public JSGNB[] getAll()
        {
            string sql = "select * from JSGNB";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            IList<JSGNB> list = new List<JSGNB>();
            while (reader.Read())
            {
                list.Add(new JSGNB((int)reader["jsbh"],(int)reader["gnbh"]));
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }

    }
}