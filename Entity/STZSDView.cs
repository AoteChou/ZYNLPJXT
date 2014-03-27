using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    /// <summary>
    /// 试题知识点视图
    /// </summary>
    public class STZSDView
    {
        private string zslymc; //专业领域名称

        public string Zslymc
        {
            get { return zslymc; }
            set { zslymc = value; }
        }
        private string zsly_bz; //专业领域备注

        public string Zsly_bz
        {
            get { return zsly_bz; }
            set { zsly_bz = value; }
        }
        private int ejzbbh; //二级指标编号

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }
        private string zsdymc; //知识单元名称

        public string Zsdymc
        {
            get { return zsdymc; }
            set { zsdymc = value; }
        }
        private string zsdy_bz; //知识单元备注

        public string Zsdy_bz
        {
            get { return zsdy_bz; }
            set { zsdy_bz = value; }
        }
        private string zsdmc; //知识点名称

        public string Zsdmc
        {
            get { return zsdmc; }
            set { zsdmc = value; }
        }
        private string zsd_bz; //知识点备注

        public string Zsd_bz
        {
            get { return zsd_bz; }
            set { zsd_bz = value; }
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
        private int stbh; //试题编号

        public int Stbh
        {
            get { return stbh; }
            set { stbh = value; }
        }
        private decimal zsdbz; //知识点比重

        public decimal Zsdbz
        {
            get { return zsdbz; }
            set { zsdbz = value; }
        }
    }
}