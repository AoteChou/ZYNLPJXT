using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //功能点
    public class GND
    {
        //功能编号
        private int gnbh;

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }

        //功能名称
        private string gnm;

        public string Gnm
        {
            get { return gnm; }
            set { gnm = value; }
        }

        //功能链接
        private string gnlj;

        public string Gnlj
        {
            get { return gnlj; }
            set { gnlj = value; }
        }

        //所属目录
        private string ssml;

        public string Ssml
        {
            get { return ssml; }
            set { ssml = value; }
        }


    }
}