using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ZYNLPJXT
{
    public partial class index : System.Web.UI.Page
    {
        private static String SqlConUrl = "server=JESSEN-PC;database=Test;uid=sa;pwd='sa'";

        protected void Page_Load(object sender, EventArgs e)
        {
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
            Response.Write("col1:"+col1+"  "+"col2:"+col2);
            con.Close();
            
        }
    }
}