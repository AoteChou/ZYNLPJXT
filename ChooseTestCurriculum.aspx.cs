using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJXT.BLL;
using ZYNLPJXT.DAL;
using ZYNLPJXT.Entity;

namespace ZYNLPJXT
{
    public partial class ChooseTestCurriculum1 : System.Web.UI.Page
    {
        public JDKCXSView[] jdkcxsviews = null;
        public int[] testNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)(Session["yh"]);
                //获取用户的阶段课程
                JDKCXSView_DAL jdkcxsview_dal = new JDKCXSView_DAL();
                jdkcxsviews = jdkcxsview_dal.getByXSBH(yh.Yhbh);
                //获取每门课程的历史测评次数
                int[] kcbhs = new int[jdkcxsviews.Length];
                for (int i=0;i<jdkcxsviews.Length;i++) {
                    kcbhs[i] = jdkcxsviews[i].Kcbh;
                }
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                testNum=pcjl_dal.getPCJLNumByKCBH(kcbhs);
            }
        }
    }
}