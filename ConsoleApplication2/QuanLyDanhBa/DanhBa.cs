using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        public KhachHang[] a = new KhachHang[100];
        int length;
        public void NhapTuFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(',');
                    Them(new KhachHang(s[0], s[1], s[2]));
                }
            }
        }
        public void Nhap()
        {
            Them(new KhachHang("012", "Nguyen Van A", "01 Phu Dong Thien Vuong"));
            Them(new KhachHang("013", "Nguyen Van B", "01 Phu Dong Thien Vuong"));
            Them(new KhachHang("014", "Nguyen Van C", "01 Nguyen Cong Tru"));
            Them(new KhachHang("017", "Nguyen Van D", "01 Nguyen Cong Tru"));
            Them(new KhachHang("018", "Nguyen Van E", "01 Nguyen Cong Tru"));
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
        public MangChuoi TimDuongSoLuongThueBaoCaoNhat(out int max)
        {
            max = TimSoLuongThueBaoCaoNhatCuaDuong();
            MangChuoi md = TimDanhSachDuong();
            MangChuoi kq = new MangChuoi();
            for (int i = 0; i < md.length; i++)
            {
                if (max == DemSoLuongThueBaoTheoDuong(md[i]))
                    kq.Them(md.a[i]);
            }
            return kq;
        }
        public int TimSoLuongThueBaoCaoNhatCuaDuong()
        {
            int max = -1;
            MangChuoi md = TimDanhSachDuong();
            for (int i = 0; i < md.length; i++)
            {
                int tam = DemSoLuongThueBaoTheoDuong(md[i]);
                if (max < tam)
                {
                    max = tam;
                }
            }
            return max;
        }
        public int DemSoLuongThueBaoTheoDuong(string duong)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
                if (a[i].diaChi.ToLower().Contains(duong.ToLower()))
                    dem++;
            return dem;
        }
        public MangChuoi TimDanhSachDuong()
        {
            MangChuoi kq = new MangChuoi();
            for (int i = 0; i < length; i++)
                kq.Them(a[i].Duong);
            return kq;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < length; i++)
                s += "\t" + a[i];
            return s;

        }
    }
}
