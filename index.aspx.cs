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
using ZYNLPJXT.DAL;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;

namespace ZYNLPJXT
{
    public partial class index : System.Web.UI.Page
    {
        protected MainMenu[] menus = null;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else {
                menus = new YHGNView_DAL().getUserMenu((YH)Session["yh"]);
            }
        }
    }
}