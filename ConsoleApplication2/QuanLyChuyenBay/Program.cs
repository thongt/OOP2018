using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachChuyenBay cb = new DanhSachChuyenBay();
            cb.Nhap();
            Console.WriteLine(cb);
            cb.TimThongTinChuyenBay("DaLat", "DaNang","Dalat");
            //Console.WriteLine(cb);
           // cb.SapXepGiamTheoNguon();
            //Console.WriteLine("\n"+cb);
            // Console.WriteLine("Danh sach chuyen bay Dalat" + cb.Vidu());
            Console.ReadKey();
        }
    }
}
