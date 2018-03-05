using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MangPhanSo
    {
        public PhanSo[] a = new PhanSo[100];
        public int len = 0;
        public void Nhap()
        {
            Console.Write("Nhap vao chieu dai mang ");
            len = int.Parse(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                a[i] = new PhanSo();
                a[i].Nhap();
            }
        }
        public void Chen(PhanSo x)
        {
            a[len] = x;
            len++;
        }
        public void NhapNgauNhien()
        {
            Console.Write("Nhap vao chieu dai mang ");
            len = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < len; i++)
            {
                a[i] = new PhanSo(r.Next(10), r.Next(10));
            }
        }
        public void NhapTuFile()
        {
            //string path = "D:\\data.txt";
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string s = "";
            while((s = sr.ReadLine())!=null)
            {
                string[] tam = s.Split('/');
                int tu = int.Parse(tam[0]);
                int mau = int.Parse(tam[1]);
                Chen(new PhanSo(tu, mau));
            }

        }
        public PhanSo TimMax()
        {
            PhanSo max = new PhanSo(int.MinValue, 1);
            for (int i = 0; i < len; i++)
            {
                float x = a[i].tu / a[i].mau;
                float y = max.tu / max.mau;
                if (x > y) max = a[i];
            }
            return max;
        }
        public void Xuat()
        {
            for (int i = 0; i < len; i++)
            {
                a[i].Xuat();
            }
        }
        //Tim tat cac cac phan so co mau la x
        public MangPhanSo TimPhanSoCoMauLa(int x)
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i = 0; i < len; i++)
            {
                if (a[i].mau == x)
                    kq.Chen(a[i]);
            }
            return kq;
        }
    }
}
