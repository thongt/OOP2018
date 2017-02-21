using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiHoc7_DuAnHinhHoc
{
    abstract class HinhHoc
    {
        //public virtual float TinhDT()
        //{
        //    return 0;
        //}
        public abstract float TinhDT();
       
    }
    class HinhTron:HinhHoc
    {
        float bk;
        public HinhTron() { }
        public HinhTron(float bk) {
            this.bk = bk;

        }
        public override float TinhDT()
        {
            return (float)Math.PI * bk * bk;
        }
        public override string ToString()
        {
            return string.Format("Hinh tron bk= {0}, dien tich = {1}", bk, TinhDT());
        }
    }
    class HinhVuong : HinhHoc
    {
        public float canh;
        public HinhVuong() { }
        public HinhVuong(float c)
        {
            this.canh = c;

        }
        public override float TinhDT()
        {
            return (float)Math.Pow(canh,2);
        }
        public override string ToString()
        {
            return string.Format("Hinh vuong canh= {0}, dien tich = {1}", canh, TinhDT());
        }
    }
    class HinhCN : HinhVuong
    {
        float rong;
        public HinhCN() { }
        public HinhCN(float cd, float rong):base(cd)
        {
            this.rong = rong;

        }
        //public override float TinhDT()
        //{
        //    return canh * rong;
        //}
        public override string ToString()
        {
            return string.Format("Hinh CN canh= {0}, dien tich = {1}", canh, TinhDT());
        }
    }
}
