using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJXT.BLL;

namespace ZYNLPJXT.processAspx
{
    public partial class GetTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int kcbh = int.Parse( Request["kcbh"]);
            GetTest_BLL gettest_dal = new GetTest_BLL();
            int stbh=gettest_dal.getSTBH(kcbh);
            Response.Redirect("../TestPage.aspx?stbh=" + stbh);
        }
    }
}