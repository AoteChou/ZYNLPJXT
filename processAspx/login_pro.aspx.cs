﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJXT.Entity;
using ZYNLPJXT.Utility;
using ZYNLPJXT.BLL;

namespace ZYNLPJXT
{
    public partial class login_pro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inputId=Request["inputId"];
            string inputPassword = Request["inputPassword"];
            Login_BLL loginBll = new Login_BLL();
            if (loginBll.isVailedYH(inputId, inputPassword))
            {
                //登录成功
                this.Session["yh"] = loginBll.getYH(inputId);
                Response.Redirect("../index.aspx");
            }
            else
            {
                //登录失败
                Response.Redirect("../Default.htm");
            }
        }
    }
}