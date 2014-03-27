using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT.DAL
{
    //学生课程View的数据库访问层
    public class XSKCView_DAL
    {
        /// <summary>
        /// 获取数据库中XSKCView的所有信息. 传入的_xskcview形参的作用是使用其中部分字段用作select语句的条件
        /// 未完成，在使用需要的时候进行添加
        /// </summary>
        public XSKCView[] getAllBySomeCondition(XSKCView _condition) {

            string sql = null;

            SqlParameter[] sqlPars = {new SqlParameter("@xsbh",_condition.Xsbh.Trim()), 
                                     };
            DbConnection dbCon = new DbConnection();
            SqlDataReader reader = dbCon.executeQuery(sql,sqlPars);
            IList<XSKCView> list = new List<XSKCView>();
            while (reader.Read())
            {
                XSKCView xskcView = new XSKCView();
                xskcView.Xsbh = (string)reader["xsbh"];
                xskcView.Kcbh = (int)reader["kcbh"];
                list.Add(xskcView);
            }
            dbCon.closeDbCon();
            return list.ToArray();
        }
    }
}