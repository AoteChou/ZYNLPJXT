using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJXT.DAL;
using ZYNLPJXT.Entity;

namespace ZYNLPJXT
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected STZSDView[] stzsdviews;
        protected int stbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            stbh=int.Parse( Request["stbh"]);
            STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
            stzsdviews = stzsdview_dal.getbySTBH(stbh);
           
        }
    }
}