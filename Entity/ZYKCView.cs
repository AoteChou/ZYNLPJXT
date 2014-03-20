using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //专业课程视图
    public class ZYKCView
    {
        private string kcjj; //课程简介

        public string Kcjj
        {
            get { return kcjj; }
            set { kcjj = value; }
        }
        private string kcmc; //课程名称

        public string Kcmc
        {
            get { return kcmc; }
            set { kcmc = value; }
        }
        private int xkbh; //学科编号

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }
        private string zym; //专业名

        public string Zym
        {
            get { return zym; }
            set { zym = value; }
        }
        private string zyfzr; //专业负责人

        public string Zyfzr
        {
            get { return zyfzr; }
            set { zyfzr = value; }
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
        private float llxf; //理论学分

        public float Llxf
        {
            get { return llxf; }
            set { llxf = value; }
        }
        private float sjxf; //实践学分

        public float Sjxf
        {
            get { return sjxf; }
            set { sjxf = value; }
        }

    }
}