using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        public KhachHang[] a = new KhachHang[100];
        int length;
        public void Nhap()
        {
            Them(new KhachHang("012", "Nguyen Van A", "01 Phu Dong Thien Vuong"));
            Them(new KhachHang("013", "Nguyen Van B", "01 Phu Dong Thien Vuong"));
            Them(new KhachHang("014", "Nguyen Van C", "01 Nguyen Cong Tru"));
            Them(new KhachHang("015", "Nguyen Van Quyen", "01 Dinh Tien Hoang"));
            Them(new KhachHang("016", "Nguyen Cong Phuong", "01 Phu Dong Thien Vuong"));
        }
        public void Them(KhachHang p)
        {
            a[length] = new KhachHang();
            a[length] = p;
            length++;
        }
        public KhachHang TimTheoSDT(string sdt)
        {
            for (int i = 0; i < length; i++)
                if (a[i].sDT == sdt) return a[i];
            return null;
        }
        public DanhBa TimTheoDuong(string duong)
        {
            DanhBa kq = new DanhBa();
            for (int i = 0; i < length; i++)
                if (a[i].diaChi.Contains(duong))
                    kq.Them(a[i]);
            return kq;
        }
        //public KhachHang Tong()
        //{
        //    KhachHang tong = new KhachHang(0, 1);
        //    for (int i = 0; i < length; i++)
        //        //tong = tong.Cong(a[i]);
        //        tong = tong + a[i];
        //    return tong;

        //}
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < length; i++)
                s += "\t" + a[i];
            return s;

        }
    }
}
