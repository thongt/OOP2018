using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class PhanSo
    {
        public int tu;
        public int mau;
        public PhanSo()
        {
            mau = 1;
        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return kq;
        }
        public PhanSo Cong(PhanSo b)
        {
            // lay this + b
            return Cong(this, b);
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return a.Cong(b);
        } 

    }
}
