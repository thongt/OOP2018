using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
             PhanSo a = new PhanSo(1,2);
            PhanSo b = a;
            b.mau = 10;
            Console.WriteLine(a);
            //// a.Nhap();
            // a.Xuat();
            //a.NghichDao();
            // PhanSo b = new PhanSo(3,4);

            ////PhanSo c = a.Cong(a, b);

            //PhanSo c = a.Cong(b).Cong(a).Cong(b);
            //Console.WriteLine("{0}+{1}={2}", a, b, c);

            //int[] a = new int[100];
            //int length = 5;

            //PhanSo[] a = new PhanSo[100];
            //int length = 5;
            //for(int i=0; i< length; i++)
            //{
            //    a[i] = new PhanSo();
            //    a[i].Nhap();
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    a[i].Xuat();
            ////}
            //PhanSo[] a = new PhanSo[] { new PhanSo(1, 2),
            //                            new PhanSo(3, 4),
            //                            new PhanSo(5),
            //                            new PhanSo()
            //};

            ////foreach (PhanSo p in a)
            ////    p.Nhap();
            //foreach (PhanSo p in a)
            //    Console.WriteLine("Phan so "+ p);


            //MangPhanSo mang = new MangPhanSo();
            //mang.Nhap();
            //Console.WriteLine(mang);
            //Console.WriteLine("Tong phan so la " + mang.Tong());
            Console.ReadKey();

        }
    }
}
