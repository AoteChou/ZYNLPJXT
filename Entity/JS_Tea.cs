using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //教师
    public class JS_Tea
    {
        /// <summary>
        /// 默认构造函数。实体字段会被赋默认值。jsbh为空字符串""，sfskcfzr为-1，sfsxkfzr为-1。
        /// </summary>
        public JS_Tea(){
            this.Sfskcfzr=-1;
            this.Sfsxkfzr=-1;
            this.Jsbh="";
        }

        public JS_Tea(string _jsbh,Int16 _sfsxkfzr,Int16 _sfskcfzr){
            this.Jsbh = _jsbh;
            this.Sfsxkfzr = _sfsxkfzr;
            this.Sfskcfzr = _sfskcfzr;
        }

        //教师编号
        private string jsbh;

        //是否是学科负责人
        private Int16 sfsxkfzr;

        /// <summary>
        /// 0表示false，1表示true。-1表示默认值
        /// </summary>
        public Int16 Sfsxkfzr
        {
            get { return sfsxkfzr; }
            set { sfsxkfzr = value; }
        }


        //是否是课程负责人
        private Int16 sfskcfzr;

        /// <summary>
        /// 0表示false，1表示true。-1表示默认值
        /// </summary>
        public Int16 Sfskcfzr
        {
            get { return sfskcfzr; }
            set { sfskcfzr = value; }
        }


        /// <summary>
        /// 默认值为空字符串""
        /// </summary>
        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }
    }
}