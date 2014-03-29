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
    /// 试题知识点视图 数据访问层
    /// </summary>
    public class STZSDView_DAL
    {
        /// <summary>
        /// 通过试题编号获取具体的知识点
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <returns>试题知识点数组</returns>
        public STZSDView[] getbySTBH(int stbh)
        {
            string sqlString = "select * from stzsdview where stbh=@stbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@stbh",stbh)
                           };

            STZSDView stzsdview = null;

            List<STZSDView> stzsdList = new List<STZSDView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
               stzsdview = new STZSDView();
               stzsdview.Stbh = stbh;
               stzsdview.Zslymc= (string)(sdReader["zslymc"]);
               stzsdview.Zsly_bz= (string)(sdReader["zsly_bz"]);
               stzsdview.Ejzbbh= (int)(sdReader["ejzbbh"]);
               stzsdview.Zsdymc= (string)(sdReader["zsdymc"]);
               stzsdview.Zsdy_bz= (string)(sdReader["zsdy_bz"]);
               stzsdview.Zsdmc= (string)(sdReader["zsdmc"]);
               stzsdview.Zsd_bz= (string)(sdReader["zsd_bz"]);
               stzsdview.Zslybh= (int)(sdReader["zslybh"]);
               stzsdview.Zsdybh= (int)(sdReader["zsdybh"]);
               stzsdview.Zsdbh= (int)(sdReader["zsdbh"]);
               stzsdview.Zsdbz= (decimal)(sdReader["zsdbz"]);
              stzsdview.Kcbh= (int)(sdReader["kcbh"]);
              stzsdview.Ctsj= (DateTime)(sdReader["ctsj"]);
              stzsdview.Ctr= (string)(sdReader["ctr"]);
              stzsdview.Sfsc = (Int16)(sdReader["sfsc"]);
              stzsdview.Kcmc = (string)(sdReader["kcmc"]);

                stzsdList.Add(stzsdview);

            }
            dbConnection.closeDbCon();
            return stzsdList.ToArray();
        }
        /// <summary>
        /// 获取拥有知识点的试题
        /// </summary>
        /// <param name="zsdbh">知识点编号</param>
        /// <returns>试题知识点数组</returns>
        public STZSDView[] getbyZSDBH(int zsdbh)
        {
            string sqlString = "select * from stzsdview where zsdbh=@zsdbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@zsdbh",zsdbh)
                           };

            STZSDView stzsdview = null;

            List<STZSDView> stzsdList = new List<STZSDView>();

            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            while (sdReader.Read())
            {
                stzsdview = new STZSDView();
                stzsdview.Stbh = (int)(sdReader["stbh"]);
                stzsdview.Zslymc = (string)(sdReader["zslymc"]);
                stzsdview.Zsly_bz = (string)(sdReader["zsly_bz"]);
                stzsdview.Ejzbbh = (int)(sdReader["ejzbbh"]);
                stzsdview.Zsdymc = (string)(sdReader["zsdymc"]);
                stzsdview.Zsdy_bz = (string)(sdReader["zsdy_bz"]);
                stzsdview.Zsdmc = (string)(sdReader["zsdmc"]);
                stzsdview.Zsd_bz = (string)(sdReader["zsd_bz"]);
                stzsdview.Zslybh = (int)(sdReader["zslybh"]);
                stzsdview.Zsdybh = (int)(sdReader["zsdybh"]);
                stzsdview.Zsdbh = zsdbh;
                stzsdview.Zsdbz = (decimal)(sdReader["zsdbz"]);
                stzsdview.Kcbh = (int)(sdReader["kcbh"]);
                stzsdview.Ctsj = (DateTime)(sdReader["ctsj"]);
                stzsdview.Ctr = (string)(sdReader["ctr"]);
                stzsdview.Sfsc = (Int16)(sdReader["sfsc"]);
                stzsdview.Kcmc = (string)(sdReader["kcmc"]);

                stzsdList.Add(stzsdview);

            }
            dbConnection.closeDbCon();
            return stzsdList.ToArray();
        }
        /// <summary>
        /// 获取特定的试题知识点
        /// </summary>
        /// <param name="stbh">试题编号</param>
        /// <param name="zsdbbh">知识点编号</param>
        /// <returns>实体知识点对象</returns>
        public STZSDView getbySTBHandZSDBH(int stbh, int zsdbh)
        {
            string sqlString = "select * from stzsdview where stbh=@stbh and zsdbh=@zsdbh";
            SqlParameter[] sqlparameters =
            {
                new SqlParameter("@stbh",stbh),
                new SqlParameter("@zsdbh",zsdbh)
                           };

            STZSDView stzsdview = new STZSDView();



            DbConnection dbConnection = new DbConnection();
            SqlDataReader sdReader = dbConnection.executeQuery(sqlString, sqlparameters);
            if (sdReader.Read())
            {
                stzsdview.Stbh = stbh;
                stzsdview.Zslymc = (string)(sdReader["zslymc"]);
                stzsdview.Zsly_bz = (string)(sdReader["zsly_bz"]);
                stzsdview.Ejzbbh = (int)(sdReader["ejzbbh"]);
                stzsdview.Zsdymc = (string)(sdReader["zsdymc"]);
                stzsdview.Zsdy_bz = (string)(sdReader["zsdy_bz"]);
                stzsdview.Zsdmc = (string)(sdReader["zsdmc"]);
                stzsdview.Zsd_bz = (string)(sdReader["zsd_bz"]);
                stzsdview.Zslybh = (int)(sdReader["zslybh"]);
                stzsdview.Zsdybh = (int)(sdReader["zsdybh"]);
                stzsdview.Zsdbh = zsdbh;
                stzsdview.Zsdbz = (decimal)(sdReader["zsdbz"]);
                stzsdview.Kcbh = (int)(sdReader["kcbh"]);
                stzsdview.Ctsj = (DateTime)(sdReader["ctsj"]);
                stzsdview.Ctr = (string)(sdReader["ctr"]);
                stzsdview.Sfsc = (Int16)(sdReader["sfsc"]);
                stzsdview.Kcmc = (string)(sdReader["kcmc"]);



            }
            dbConnection.closeDbCon();
            return stzsdview;
        }
    }
}