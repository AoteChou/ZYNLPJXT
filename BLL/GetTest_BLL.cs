using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.DAL;

namespace ZYNLPJXT.BLL
{
    public class GetTest_BLL
    {
        /// <summary>
        /// 获取试题编号
        /// </summary>
        /// <param name="kcbh">课程编号</param>
        /// <returns></returns>
        public int getSTBH(int kcbh) {
            int stbh = -1;
            ST_DAL st_dal=new ST_DAL();
            //这里写算法 之后补充
            stbh = 2;
            return stbh;
        }
    }
}