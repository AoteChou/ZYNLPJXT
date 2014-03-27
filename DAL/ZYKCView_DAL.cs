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
    /// 专业课程视图 数据访问层
    /// </summary>
    public class ZYKCView_DAL
    {
        /// <summary>
        /// 通过专业编号获取专业下的所有课程信息
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <returns>专业课程视图数组</returns>
        public ZYKCView[] getbyZYBH(int zybh)
        {
            string sqlString = "select * from zykcview where zybh=@zybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh)
                           };

            ZYKCView zykcview = new ZYKCView();

            List<ZYKCView> zykcList = new List<ZYKCView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                zykcview.Zybh = zybh;
                zykcview.Kcjj = (string)(sdReader["kcjj"]);
                zykcview.Kcmc= (string)(sdReader["kcmc"]);
                zykcview.Xkbh= (int)(sdReader["xkbh"]);
                zykcview.Zym= (string)(sdReader["zym"]);
                zykcview.Zyfzr= (string)(sdReader["zyfzr"]);
                zykcview.Kcbh= (int)(sdReader["kcbh"]);
                zykcview.Kcxzbh= (int)(sdReader["kcxzbh"]);
                zykcview.Kkxq= (int)(sdReader["kkxq"]);
                zykcview.Llxf= (decimal)(sdReader["llxf"]);
                zykcview.Sjxf= (decimal)(sdReader["sjxf"]);
                zykcview.Kcxzmc= (string)(sdReader["kcxzmc"]);
                
                zykcList.Add(zykcview);

            }
            dbConnection.closeDbCon();
            return zykcList.ToArray();
        }
        /// <summary>
        /// 通过专业编号和课程编号获取特定的专业课程信息
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>专业课程视图（单个）</returns>
        public ZYKCView getbyZYBHandKCBH(int zybh,int kcbh)
        {
            string sqlString = "select * from zykcview where zybh=@zybh and kcbh=@kcbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@kcbh",kcbh)
                           };

            ZYKCView zykcview = new ZYKCView();

           

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zykcview.Zybh = zybh;
                zykcview.Kcjj = (string)(sdReader["kcjj"]);
                zykcview.Kcmc = (string)(sdReader["kcmc"]);
                zykcview.Xkbh = (int)(sdReader["xkbh"]);
                zykcview.Zym = (string)(sdReader["zym"]);
                zykcview.Zyfzr = (string)(sdReader["zyfzr"]);
                zykcview.Kcbh = kcbh;
                zykcview.Kcxzbh = (int)(sdReader["kcxzbh"]);
                zykcview.Kkxq = (int)(sdReader["kkxq"]);
                zykcview.Llxf = (decimal)(sdReader["llxf"]);
                zykcview.Sjxf = (decimal)(sdReader["sjxf"]);
                zykcview.Kcxzmc = (string)(sdReader["kcxzmc"]);
                

            }
            dbConnection.closeDbCon();
            return zykcview;
        }
    }
}