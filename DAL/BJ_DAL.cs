using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    //班级 数据访问层
    public class BJ_DAL
    {
        public BJ getBJbyBH(int id) { 
            
            //string sql = "select * from BJ where BJBH='" + id + "'";
            string sql = "select * from tabone";
            BJ bj=new BJ();
            string col1 = null, col2 = null;
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            if (reader.Read())
            {
                col1 = reader.GetString(0);
                col2 = reader.GetString(1);
            }
            bj.Bjmc = col1;
            dbCon.closeDbCon();
            return bj;
        }
    }
}