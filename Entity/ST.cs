using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //试题
    public class ST
    {
        private int stbh; //试题编号

        public int Stbh
        {
            get { return stbh; }
            set { stbh = value; }
        }
        private int kcbh; //课程编号

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }
        private DateTime ctsj; //出图时间

        public DateTime Ctsj
        {
            get { return ctsj; }
            set { ctsj = value; }
        }
        private string tmnr; //题目内容

        public string Tmnr
        {
            get { return tmnr; }
            set { tmnr = value; }
        }
        private string tmda; //题目答案

        public string Tmda
        {
            get { return tmda; }
            set { tmda = value; }
        }
        private string ctr; //出题人

        public string Ctr
        {
            get { return ctr; }
            set { ctr = value; }
        }
        private string gtr; //改题人

        public string Gtr
        {
            get { return gtr; }
            set { gtr = value; }
        }
        private bool sfzdyj; //是否自动阅卷

        public bool Sfzdyj
        {
            get { return sfzdyj; }
            set { sfzdyj = value; }
        }
        private bool sfsc; //是否删除

        public bool Sfsc
        {
            get { return sfsc; }
            set { sfsc = value; }
        }


    }
}