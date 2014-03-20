using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //阶段课程学分View
    public class JDKCXSView
    {
        //学生编号
        private string xsbh;

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
        }

        //教师编号
        private string jsbh;

        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

        //阶段名称
        private string jdmc;

        public string Jdmc
        {
            get { return jdmc; }
            set { jdmc = value; }
        }

        //起始学期
        private int qsxq;

        public int Qsxq
        {
            get { return qsxq; }
            set { qsxq = value; }
        }

        //截止学期
        private int jzxq;

        public int Jzxq
        {
            get { return jzxq; }
            set { jzxq = value; }
        }

        //测评阶段简介
        private string cpjdjj;

        public string Cpjdjj
        {
            get { return cpjdjj; }
            set { cpjdjj = value; }
        }

        
        //阶段编号
        private int jdbh;

        public int Jdbh
        {
            get { return jdbh; }
            set { jdbh = value; }
        }

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

        //课程简介
        private string kcjj;

        public string Kcjj
        {
            get { return kcjj; }
            set { kcjj = value; }
        }

        //课程名称
        private string kcmc;

        public string Kcmc
        {
            get { return kcmc; }
            set { kcmc = value; }
        }

        //学科编号
        private int xkbh;

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }

        //专业名
        private string zym;

        public string Zym
        {
            get { return zym; }
            set { zym = value; }
        }

        //专业负责人
        private string zyfzr;

        public string Zyfzr
        {
            get { return zyfzr; }
            set { zyfzr = value; }
        }

        //课程编号
        private int kcbh;

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }

        //专业编号
        private int zybh;

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }

        //课程性质编号
        private int kcxzbh;

        public int Kcxzbh
        {
            get { return kcxzbh; }
            set { kcxzbh = value; }
        }

        //开课学期
        private int kkxq;

        public int Kkxq
        {
            get { return kkxq; }
            set { kkxq = value; }
        }

        //理论学分
        private float llxf;

        public float Llxf
        {
            get { return llxf; }
            set { llxf = value; }
        }

        //实践学分
        private int sjxf;

        public int Sjxf
        {
            get { return sjxf; }
            set { sjxf = value; }
        }


        //课程性质名称
        private string kcxzmc;

        public string Kcxzmc
        {
            get { return kcxzmc; }
            set { kcxzmc = value; }
        }
    }
}