using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //教师
    public class JS_Tea
    {
        //教师编号
        private string jsbh;

        //是否是学科负责人
        private bool sfsxkfzr;

        public bool Sfsxkfzr
        {
            get { return sfsxkfzr; }
            set { sfsxkfzr = value; }
        }


        //是否是课程负责人
        private bool sfskcfzr;

        public bool Sfskcfzr
        {
            get { return sfskcfzr; }
            set { sfskcfzr = value; }
        }


        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }
    }
}