using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //试题
    public class ST
    {
        public ST()
        {
          stbh= -1;
          kcbh= -1;
          ctsj = DateTime.Parse("1753/1/1");
          tmnr= "";
          tmda= "";
          ctr= "";
          sfzdyj= -1;
          sfsc=-1;
        }
        
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
        
        private Int16 sfzdyj; //是否自动阅卷

        public Int16 Sfzdyj
        {
            get { return sfzdyj; }
            set { sfzdyj = value; }
        }
        private Int16 sfsc; //是否删除

        public Int16 Sfsc
        {
            get { return sfsc; }
            set { sfsc = value; }
        }


    }
}