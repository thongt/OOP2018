using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class Program
    {
        enum Menu
        {
            Thoat =10,
            NhapTuFile=1,
            Xuat =2,
            TimMax,
            TimTheoMau
        }
        static void Main(string[] args)
        {
            //PhanSo a = new PhanSo(1,2);
            //a.Xuat();
            //a.Nhap();
            //a.Xuat();
            //PhanSo b = new PhanSo(3,4);
            //b.Xuat();

            //a.Cong(a, b).Xuat();
            //a.Cong(b).Xuat();
            //PhanSo c = a + b;
            //c.Xuat();
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file ", (int)Menu.NhapTuFile);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case Menu.Thoat: return;
                    case Menu.NhapTuFile:
                        ds.NhapTuFile();
                        break;
                    case Menu.TimMax:
                        ds.TimMax().Xuat();
                        break;
                }
            }


            //ds.NhapTuFile();
            //ds.Xuat();
            //// Console.WriteLine("Phan so lon nhat la ");
            ////ds.TimMax().Xuat();
            //Console.WriteLine("Tim theo mau");
            //ds.TimPhanSoCoMauLa(5).Xuat();
            Console.ReadKey();
        }
    }
}
