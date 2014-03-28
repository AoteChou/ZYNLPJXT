using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //评测记录
    public class PCJL
    {
        public PCJL()
        {
          stbh= -1;
          xsbh= "";
          xzrq = DateTime.Parse("1753/1/1");
          scrq = DateTime.Parse("1753/1/1");
          pcfs= -1;
          pcjlbh= -1;
          gtr= "";
          xsstda = "";
        }
        private int pcjlbh; //评测记录编号

        public int Pcjlbh
        {
            get { return pcjlbh; }
            set { pcjlbh = value; }
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
        private string gtr; //改题人

        public string Gtr
        {
            get { return gtr; }
            set { gtr = value; }
        }
        private string xsstda;//学生试题答案

        public string Xsstda
        {
            get { return xsstda; }
            set { xsstda = value; }
        }


    }
}