using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong
{
    class MangPhanSo
    {
        public PhanSo[] a = new PhanSo[100];
        int length;
        public void Nhap() {
            Them(new PhanSo(1, 2));
            Them(new PhanSo(2,3 ));
            Them(new PhanSo(3, 4));
            Them(new PhanSo(1, 5));
            Them(new PhanSo(1, 6));
        }
        public void Them(PhanSo p)
        {
            a[length] = new PhanSo();
            a[length] = p;
            length++;
        }
        public PhanSo Tong()
        {
            PhanSo tong = new PhanSo(0, 1);
            for (int i = 0; i < length; i++)
                //tong = tong.Cong(a[i]);
                tong = tong + a[i];
            return tong;

        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < length; i++)
                s += "\t" + a[i];
            return s;

        }


    }
}
