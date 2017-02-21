using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc8_SuTruuTuong
{
    class Program
    {
        static void Main(string[] args)
        {

            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            ds.Nhap();
            Console.WriteLine(ds);

            Console.ReadKey();
        }
    }
}
