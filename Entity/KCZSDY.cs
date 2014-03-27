using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //课程知识单元
    public class KCZSDY
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public KCZSDY() {
            this.Kcbh = -1;
            this.Zsdybh = -1;
            this.Zslybh = -1;
        }

        public KCZSDY(int _kcbh, int _zsdybh, int _zslybh) {
            this.Kcbh = _kcbh;
            this.Zsdybh = _zsdybh;
            this.Zslybh = _zslybh;
        }

        //课程编号
        private int kcbh;

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }

        //知识领域编号
        private int zslybh;

        public int Zslybh
        {
            get { return zslybh; }
            set { zslybh = value; }
        }

        //知识单元编号
        private int zsdybh;

        public int Zsdybh
        {
            get { return zsdybh; }
            set { zsdybh = value; }
        }

    }
}