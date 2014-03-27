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
    /// 出题视图 数据访问层
    /// </summary>
    public class CTView_DAL
    {
        /// <summary>
        /// 通过专业编号和课程编号来找出题人信息
        /// </summary>
        /// <param name="zybh">专业编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>出题视图</returns>
        public CTView getbyZYBHandKCBH(int zybh, int kcbh)
        {
            string sqlString = "select * from ctview where zybh=@zybh and kcbh=@kcbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zybh",zybh),
                new SqlParameter("@kcbh",kcbh)
                           };

            CTView ctview = new CTView();

           

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                ctview.Zybh = zybh;
                ctview.Kcjj = (string)(sdReader["kcjj"]);
                ctview.Kcmc = (string)(sdReader["kcmc"]);
                ctview.Xkbh = (int)(sdReader["xkbh"]);
                ctview.Zym = (string)(sdReader["zym"]);
                ctview.Zyfzr = (string)(sdReader["zyfzr"]);
                ctview.Kcbh = (int)(sdReader["kcbh"]);
                ctview.Kcxzbh = (int)(sdReader["kcxzbh"]);
                ctview.Kkxq = (int)(sdReader["kkxq"]);
                ctview.Llxf = (decimal)(sdReader["llxf"]);
                ctview.Sjxf = (decimal)(sdReader["sjxf"]);
                ctview.Kcxzmc = (string)(sdReader["kcxzmc"]);
                ctview.Ctr = (string)(sdReader["ctr"]);


            }
            dbConnection.closeDbCon();
            return ctview;
        }
        /// <summary>
        /// 获取一个出题人所有的科目
        /// </summary>
        /// <param name="ctr">出题人编号</param>
        /// <returns>出题视图 数组</returns>
        public CTView[] getbyCTR(string ctr)
        {
            string sqlString = "select * from ctview where ctr=@ctr";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@ctr",ctr)
                           };

            List<CTView> ctList = new List<CTView>();
            CTView ctview = new CTView();



            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                ctview.Zybh = (int)(sdReader["zybh"]);
                ctview.Kcjj = (string)(sdReader["kcjj"]);
                ctview.Kcmc = (string)(sdReader["kcmc"]);
                ctview.Xkbh = (int)(sdReader["xkbh"]);
                ctview.Zym = (string)(sdReader["zym"]);
                ctview.Zyfzr = (string)(sdReader["zyfzr"]);
                ctview.Kcbh = (int)(sdReader["kcbh"]);
                ctview.Kcxzbh = (int)(sdReader["kcxzbh"]);
                ctview.Kkxq = (int)(sdReader["kkxq"]);
                ctview.Llxf = (decimal)(sdReader["llxf"]);
                ctview.Sjxf = (decimal)(sdReader["sjxf"]);
                ctview.Kcxzmc = (string)(sdReader["kcxzmc"]);
                ctview.Ctr = ctr;

                ctList.Add(ctview);
            }
            dbConnection.closeDbCon();
            return ctList.ToArray();
        }
    }
}