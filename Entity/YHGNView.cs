using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //用户功能视图
    public class YHGNView
    {
        private string gnm; //功能名

        public string Gnm
        {
            get { return gnm; }
            set { gnm = value; }
        }
        private string gnlj; //功能链接

        public string Gnlj
        {
            get { return gnlj; }
            set { gnlj = value; }
        }
        private string ssml; //所属目录

        public string Ssml
        {
            get { return ssml; }
            set { ssml = value; }
        }
        private int gnbh; //功能编号

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }
        private string yhbh; //用户编号

        public string Yhbh
        {
            get { return yhbh; }
            set { yhbh = value; }
        }

    }
}