using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJXT.Entity;
using ZYNLPJXT.DAL;

namespace ZYNLPJXT.BLL
{
    public class Login_BLL
    {
        public bool isVailedYH(string _yhbh,string _mm) {
            if (isNull(_yhbh, _mm))
            {
                return false;
            }
            else {
                if (new YH_DAL().isExist(new YH(_yhbh, _mm, "", -1)))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        protected bool isNull(string _yhbh, string _mm)
        {
            if (_yhbh == null || _mm == null)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public YH getYH(string yhbh) {
            return new YH_DAL().getYH(yhbh);
        }

    }
}