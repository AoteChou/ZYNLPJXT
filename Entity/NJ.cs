using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //年级
    public class NJ
    {
        //年级编号
        private int njbh;

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }

        //年级名称 
        private string njmc;

        public string Njmc
        {
            get { return njmc; }
            set { njmc = value; }
        }
    }
}