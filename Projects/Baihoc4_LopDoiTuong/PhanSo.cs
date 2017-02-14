using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong
{
    class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo( int m)
        {
            mau = m;
        }
        
        public void Nhap()
        {
            Console.WriteLine("Nhap tu ");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau ");
            mau = int.Parse(Console.ReadLine());
        }
        //public void Xuat()
        //{
        //    Console.WriteLine("{0}/{1}",tu, mau);
        //}
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tu = a.tu * b.mau + a.mau * b.tu;
            c.mau = a.mau * b.mau;
            return c;
        }
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            return a.Cong(b);
        }
        public PhanSo Cong( PhanSo b)
        {
            return this.Cong(this, b);
        }
        public void NghichDao()
        {
            int tam = tu;
            tu = mau;
            mau = tam;
             

        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", tu, mau); 
        }
        
           
        
    }
}
