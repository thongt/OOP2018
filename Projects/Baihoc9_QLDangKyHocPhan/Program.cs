using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class Program
    {
        static void Main(string[] args)
        {

            QLDangKyHocPhan ql = new QLDangKyHocPhan();
            ql.Xuat();
            ql.XuatKQDKHPTheoMaSinhVien2("001CTK39");
            ql.XoaKQDKHP("001CTK39", new string[] { "001","002" });
            ql.XuatKQDKHPTheoMaSinhVien2("001CTK39");
            Console.ReadKey();
        }
    }
}
