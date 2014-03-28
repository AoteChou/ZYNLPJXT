using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    /// <summary>
    /// 用户功能视图 数据访问层
    /// </summary>
    public class YHGNView_DAL
    {
        /// <summary>
        /// 获取用户所有的功能点
        /// </summary>
        /// <param name="yhbh">用户编号</param>
        /// <returns>功能点数组</returns>
        public YHGNView[] getbyYHBH(string yhbh)
        {
            string sqlString = "select * from yhgnview where yhbh=@yhbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yhbh)
                           };

            YHGNView yhgnview = new YHGNView();

            List<YHGNView> yhgnList = new List<YHGNView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                yhgnview.Yhbh = yhbh;
                yhgnview.Gnm=(string)(sdReader["gnm"]);
                yhgnview.Gnlj=(string)(sdReader["gnlj"]);
                yhgnview.Ssml=(string)(sdReader["ssml"]);
                yhgnview.Gnbh=(int)(sdReader["gnbh"]);
     
                yhgnList.Add(yhgnview);

            }
            dbConnection.closeDbCon();
            return yhgnList.ToArray();
        }


        public MainMenu[] getUserMenu(YH yh) {

            string sql = "select distinct SSML from YHGNView where yhbh='"+yh.Yhbh.Trim()+"'";
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql);
            List<string> ssmls = new List<string>();
            while (reader.Read()) {
                ssmls.Add((string)reader["ssml"]);
            }
            reader.Close();
            dbCon.closeDbCon();

            
             DbConnection dbCon2 = new DbConnection();
            List<MainMenu> mainMenus=new List<MainMenu> ();
            foreach(string ssml in ssmls){
                string realSql = "select * from YHGNView where yhbh=@yhbh and ssml=@ssml";
                SqlParameter[] sqlPars = { new SqlParameter("@yhbh",yh.Yhbh),
                                           new SqlParameter("@ssml",ssml)
                                         };
                SqlDataReader realReader = dbCon2.executeQuery(realSql, sqlPars);
                List<ItemMenu> itemMenus = new List<ItemMenu>();
                while (realReader.Read()) {
                    itemMenus.Add(new ItemMenu((string)realReader["gnm"],(string)realReader["gnlj"],(int)realReader["gnbh"]));
                }
                realReader.Close();
                mainMenus.Add(new MainMenu(ssml,itemMenus.ToArray()));
            }

            MainMenu[] mainMenuArray=mainMenus.ToArray();
            dbCon2.closeDbCon();
            return mainMenuArray;
        }

    }
}