using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //评测记录
    public class PCJL
    {
        private int pcjvbh; //评测记录编号

        public int Pcjvbh
        {
            get { return pcjvbh; }
            set { pcjvbh = value; }
        }
        private int stbh; //试题编号

        public int Stbh
        {
            get { return stbh; }
            set { stbh = value; }
        }
        private string xsbh; //学生编号

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
        }

       
        private DateTime xzrq; //下载日期

        public DateTime Xzrq
        {
            get { return xzrq; }
            set { xzrq = value; }
        }
        private DateTime scrq; //上传日期

        public DateTime Scrq
        {
            get { return scrq; }
            set { scrq = value; }
        }
        private int pcfs; //评测分数

        public int Pcfs
        {
            get { return pcfs; }
            set { pcfs = value; }
        }

    }
}