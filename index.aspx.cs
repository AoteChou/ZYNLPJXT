using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ZYNLPJXT
{
    public partial class index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string SqlConUrl=ConfigurationManager.AppSettings["connectionStr"];

            SqlConnection con = new SqlConnection(SqlConUrl);
            con.Open();
            SqlCommand sqlCom = new SqlCommand("select * from tabone");
            sqlCom.Connection = con;
            SqlDataReader reader=sqlCom.ExecuteReader();
            string col1=null,col2=null;
            if(reader.Read()){
                col1=reader.GetString(0);
                col2=reader.GetString(1);
            }
            Response.Write("col1:" + col1 + "  " + "col2:" + col2 + SqlConUrl);
            con.Close();
            */
        }
    }
}