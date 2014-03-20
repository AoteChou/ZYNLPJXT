using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //课程性质
    public class KCXZ
    {
        //课程性质编号
        private int kcxzbh;

        public int Kcxzbh
        {
            get { return kcxzbh; }
            set { kcxzbh = value; }
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