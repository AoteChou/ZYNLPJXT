using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //专业课程
    public class ZYKC 
    {
        public ZYKC()
        {
            kcbh= -1;
            zybh= -1;
            kcxzbh= -1;
            kkxq= -1;
            llxf= -1;
            sjxf= -1;
        }
        private int kcbh; //课程编号

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }
        private int zybh; //专业编号
        
        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }
        private int kcxzbh; //课程性质编号

        public int Kcxzbh
        {
            get { return kcxzbh; }
            set { kcxzbh = value; }
        }
        private int kkxq; //开课学期

        public int Kkxq
        {
            get { return kkxq; }
            set { kkxq = value; }
        }
        private decimal llxf; //理论学分

        public decimal Llxf
        {
            get { return llxf; }
            set { llxf = value; }
        }
        private decimal sjxf; //实践学分

        public decimal Sjxf
        {
            get { return sjxf; }
            set { sjxf = value; }
        }


    }
}