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
            Console.WriteLine("Danh ba khach hang \n" + db);
            //Console.WriteLine("\n\n\n" + db.TimTheoSDT("012"));
            Console.WriteLine("Danh sach khach hang duong phu dong");
            Console.WriteLine(db.TimTheoDuong("Phu Dong Thien Vuong"));
            Console.ReadKey();

        }
    }
}
