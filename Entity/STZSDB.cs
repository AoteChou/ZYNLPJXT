using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //试题知识点表
    public class STZSDB
    {
        public STZSDB()
        {
             zslybh= -1;
             zsdybh= -1;
             zsdbh= -1;
             stbh= -1;
             zsdbz= -1;
        }
        private int zslybh; //知识领域编号

        public int Zslybh
        {
            get { return zslybh; }
            set { zslybh = value; }
        }
        private int zsdybh; //知识单元编号

        public int Zsdybh
        {
            get { return zsdybh; }
            set { zsdybh = value; }
        }
        private int zsdbh; //知识点编号

        public int Zsdbh
        {
            get { return zsdbh; }
            set { zsdbh = value; }
        }
        private int stbh; //实体编号

        public int Stbh
        {
            get { return stbh; }
            set { stbh = value; }
        }
        private float zsdbz; //知识点比重

        public float Zsdbz
        {
            get { return zsdbz; }
            set { zsdbz = value; }
        }


    }
}