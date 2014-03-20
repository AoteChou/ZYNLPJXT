using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学生
    public class XS
    {
        private int bjbh; //班级编号

        public int Bjbh
        {
            get { return bjbh; }
            set { bjbh = value; }
        }
        private string xsbh; //学生编号

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
        }
        private DateTime rxnf; //入学年份

        public DateTime Rxnf
        {
            get { return rxnf; }
            set { rxnf = value; }
        }

    }
}