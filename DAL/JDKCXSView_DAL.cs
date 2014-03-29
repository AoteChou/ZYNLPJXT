using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using System.Data.SqlClient;

namespace ZYNLPJXT.DAL
{
    //阶段课程学生JDKCXSView 的数据访问层
    public class JDKCXSView_DAL
    {
        public JDKCXSView[] getAllByCondition(int _condition) {
            return null;
        }
        /// <summary>
        /// 获取学生的阶段课程
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <returns>阶段课程学生视图（数组）</returns>
        public JDKCXSView[] getByXSBH(string xsbh) {
            string sqlString = "select * from jdkcxsview where xsbh=@xsbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@xsbh",xsbh)
                           };

            JDKCXSView jdkcxsview = null;

            List<JDKCXSView> jdkcxsList = new List<JDKCXSView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                jdkcxsview = new JDKCXSView();
                jdkcxsview.Xsbh = xsbh;
      
                jdkcxsview.Jsbh= (string)(sdReader["jsbh"]);
                jdkcxsview.Jdmc= (string)(sdReader["jdmc"]);
                jdkcxsview.Qsxq= (int)(sdReader["qsxq"]);
                jdkcxsview.Jzxq= (int)(sdReader["jzxq"]);
                jdkcxsview.Cpjdjj= (string)(sdReader["cpjdjj"]);
                jdkcxsview.Jdbh= (int)(sdReader["jdbh"]);
                jdkcxsview.Njbh= (int)(sdReader["njbh"]);
                jdkcxsview.Njmc= (string)(sdReader["njmc"]);
                jdkcxsview.Kcjj= (string)(sdReader["kcjj"]);
                jdkcxsview.Kcmc= (string)(sdReader["kcmc"]);
                jdkcxsview.Xkbh= (int)(sdReader["xkbh"]);
                jdkcxsview.Zym= (string)(sdReader["zym"]);
                jdkcxsview.Zyfzr= (string)(sdReader["zyfzr"]);
                jdkcxsview.Kcbh= (int)(sdReader["kcbh"]);
                jdkcxsview.Zybh= (int)(sdReader["zybh"]);
                jdkcxsview.Kcxzbh= (int)(sdReader["kcxzbh"]);
                jdkcxsview.Kkxq= (int)(sdReader["kkxq"]);
                jdkcxsview.Llxf= (decimal)(sdReader["llxf"]);
                jdkcxsview.Sjxf= (decimal)(sdReader["sjxf"]);
                jdkcxsview.Kcxzmc= (string)(sdReader["kcxzmc"]);
                
                jdkcxsList.Add(jdkcxsview);

            }
            dbConnection.closeDbCon();
            
            return jdkcxsList.ToArray();
        }
    }
}