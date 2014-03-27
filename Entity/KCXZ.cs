using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //课程性质
    public class KCXZ
    {
        public KCXZ() {
            this.Kcxzbh = -1;
            this.Kcxzmc = "";
        }

        /// <summary>
        /// insert函数使用
        /// </summary>
        public KCXZ(string _kcxzmc) {
            this.Kcxzmc = _kcxzmc;
        }
        
        /// <summary>
        /// get和update函数使用
        /// </summary>
        /// <param name="_kcxzbh"></param>
        /// <param name="_kcxzmc"></param>
        public KCXZ(int _kcxzbh, string _kcxzmc) {
            this.Kcxzbh = _kcxzbh;
            this.Kcxzmc = _kcxzmc;
        }

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