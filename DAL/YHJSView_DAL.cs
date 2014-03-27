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
    /// 用户角色视图 数据访问层
    /// </summary>
    public class YHJSView_DAL
    {
        /// <summary>
        /// 通过用户编号获取用户的角色
        /// </summary>
        /// <param name="yhbh">用户编号</param>
        /// <returns>用户角色视图</returns>
        public YHJSView[] getbyYHBH(string yhbh)
        {
            string sqlString = "select * from yhjsview where yhbh=@yhbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@yhbh",yhbh)
                           };

            YHJSView yhjsview = new YHJSView();

            List<YHJSView> yhjsList = new List<YHJSView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                yhjsview.Yhbh = yhbh;
                yhjsview.Jsm= (string)(sdReader["jsm"]);
                yhjsview.Mm= (string)(sdReader["mm"]);
                yhjsview.Xm= (string)(sdReader["xm"]);
                yhjsview.Xb= (int)(sdReader["xb"]);
                yhjsview.Jsbh= (int)(sdReader["jsbh"]);
           
                yhjsList.Add(yhjsview);

            }
            dbConnection.closeDbCon();
            return yhjsList.ToArray();
        }
    }
}