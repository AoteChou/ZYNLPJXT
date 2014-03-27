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
    /// 专业二级指标视图 数据访问层
    /// </summary>
    public class ZYEJZBView_DAL
    {
        /// <summary>
        /// 通过专业编号获取专业二级指标
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <returns>专业二级编号视图数组</returns>
        public ZYEJZBView[] getbyZYBH(int zybh)
        {
            string sqlString = "select * from zyejzbview where zybh=@zybh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh)
                           };

            ZYEJZBView zyejzbview = new ZYEJZBView();

            List<ZYEJZBView> zykcList = new List<ZYEJZBView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                zyejzbview.Zybh = zybh;
             
                zyejzbview.Xkbh= (int)(sdReader["xkbh"]);
                zyejzbview.Zym= (string)(sdReader["zym"]);
                zyejzbview.Zyfzr= (string)(sdReader["zyfzr"]);
                zyejzbview.Yjzbbh= (int)(sdReader["yjzbbh"]);
                zyejzbview.Ejzbmc= (string)(sdReader["ejzbmc"]);
                zyejzbview.Ejzbbh= (int)(sdReader["ejzbbh"]);
                zyejzbview.Nlyq= (int)(sdReader["nlyq"]);

                zykcList.Add(zyejzbview);

            }
            dbConnection.closeDbCon();
            return zykcList.ToArray();
        }
       /// <summary>
       /// 获取特定的专业二级指标
       /// </summary>
       /// <param name="zybh">专业编号</param>
       /// <param name="ejzbbh">二级指标编号</param>
       /// <returns>专业二级指标</returns>
        public ZYEJZBView getbyZYBHandKCBH(int zybh, int ejzbbh)
        {
            string sqlString = "select * from zyejzbview where zybh=@zybh and ejzbbh=@ejzbbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@ejzbbh",ejzbbh)
                           };

            ZYEJZBView zyejzbview = new ZYEJZBView();



            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                zyejzbview.Zybh = zybh;

                zyejzbview.Xkbh = (int)(sdReader["xkbh"]);
                zyejzbview.Zym = (string)(sdReader["zym"]);
                zyejzbview.Zyfzr = (string)(sdReader["zyfzr"]);
                zyejzbview.Yjzbbh = (int)(sdReader["yjzbbh"]);
                zyejzbview.Ejzbmc = (string)(sdReader["ejzbmc"]);
                zyejzbview.Ejzbbh = (int)(sdReader["ejzbbh"]);
                zyejzbview.Nlyq = (int)(sdReader["nlyq"]);
                


            }
            dbConnection.closeDbCon();
            return zyejzbview;
        }
    }
}