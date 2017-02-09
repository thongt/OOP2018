using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuV2
{
    class Program
    {
        enum ThucDon
        {
            NhapThuCong = 0,
            NhapTuFile = 3,
            Xuat,
            TinhTong,
            Thoat
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int length = 0;
            NhapTuFile(a, ref length);
            //ChenTaiViTri(a, ref length, 0, 2000);
            Xuat(a, length);
            SapXepTang(a, length);
          //  XoaTaiViTri(a, length,3);
            Xuat(a, length);
            while (true)
            {
                Console.WriteLine("\n".PadRight(40, '*'));
                Console.WriteLine("\nNhap {0} de nhap thu cong", (int)ThucDon.NhapThuCong);
                Console.WriteLine("Nhap {0} de nhap tu file", (int)ThucDon.NhapTuFile);
                Console.WriteLine("Nhap {0} de nhap xuat", (int)ThucDon.Xuat);
                Console.WriteLine("Nhap {0} de tinh tong", (int)ThucDon.TinhTong);
                Console.WriteLine("Nhap {0} de thoat!!!!", (int)ThucDon.Thoat);
                ThucDon td = (ThucDon)int.Parse(Console.ReadLine());
                switch (td)
                {
                    case ThucDon.NhapThuCong:
                        NhapTuBanPhim(a, ref length);
                        break;
                    case ThucDon.NhapTuFile:
                        NhapTuFile(a, ref length);
                        break;
                    case ThucDon.Xuat:
                        Xuat(a, length); break;

                    case ThucDon.TinhTong:
                        Console.WriteLine("Tong cac phan tu la " + TinhTong(a, length)); break;
                    case ThucDon.Thoat:
                        return;
                }
            }
            // Console.ReadKey();

        }
        static void NhapTuBanPhim(int[] mang, ref int length)

        {
            Console.Write("\nNhap chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}]=", i);
                mang[i] = int.Parse(Console.ReadLine());
            }

        }
        static void NhapTuFile(int[] mang, ref int length)
        {
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\Tran Thong\Source\Repos\OOP2018\ConsoleApplication2\Mang1Chieu\data.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    mang[length++] = int.Parse(line);
                }
            }
        }
        static void Xuat(int[] mang, int length)
        {
            Console.WriteLine("\nCac gia tri cua mang");
            for (int i = 0; i < length; i++)
                Console.Write(" " + mang[i]);
        }

        static int TinhTong(int[] mang, int length)
        {
            int tong = 0;
            for (int i = 0; i < length; i++)
                tong += mang[i];
            return tong;
        }

        static bool ChenTaiViTri(int[] mang, ref int length, int vt, int x)
        {
            if (vt < 0 || vt > length + 1) return false;
            for (int i = length; i > vt; i--)
                mang[i] = mang[i - 1];
            mang[vt] = x;
            length++;
            return true;
        }
        static bool ChenDau(int[] mang, ref int length, int x)
        {
            return ChenTaiViTri(mang, ref length, 0, x);
        }
        static bool XoaTaiViTri(int[] mang, ref int length, int vt)
        {
            if (vt < 0 || vt > length + 1) return false;
            for (int i = vt; i < length; i++)
                mang[i] = mang[i + 1];

            length--;
            return true;
        }
        static void XoaTatCa(int[] mang, ref int length)
        {
            length = 0;
        }
        static int TimMax(int[] mang,  int length)
        {
            int max = int.MinValue;
            for (int i = 0; i < length; i++)
                if (max < mang[i])
                    max = mang[i];
            return max;
        }
        static int TimMin(int[] mang, int length)
        {
            int min = int.MaxValue;
            for (int i = 0; i < length; i++)
                if (min > mang[i])
                    min = mang[i];
            return min;
        }
        static void SapXepTang(int[] mang, int length)
        {
            for(int i=0; i< length; i++)
                for (int j = i+1; j < length; j++)
                    if(mang[i]>mang[j])
                    {
                        var tam = mang[i];
                        mang[i] = mang[j];
                        mang[j] = tam;
                    }
        }

    }
}
