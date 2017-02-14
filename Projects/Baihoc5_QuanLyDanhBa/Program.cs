using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhBa db = new DanhBa();
            db.Nhap();
            db.NhapTuFile();
            Console.WriteLine("Danh ba khach hang \n" + db);
            //Console.WriteLine("\n\n\n" + db.TimTheoSDT("012"));
            //Console.WriteLine("Danh sach khach hang duong phu dong");
            //Console.WriteLine(db.TimTheoDuong("Phu Dong Thien Vuong"));
            int max = 0;
            // string duong = db.TimDuongSoLuongThueBaoCaoNhat(ref max);
            //Console.WriteLine("Duong {0} co so luong cao nhat la {1}",duong, max);
            // Console.WriteLine(db.TimDanhSachDuong());

            Console.WriteLine(db.TimDuongSoLuongThueBaoCaoNhat(out max));
            Console.WriteLine("So luong cao nhat la " + max);
            Console.ReadKey();

        }
    }
}
