using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    class DanhSachChuyenBay
    {
        public ChuyenBay[] a = new ChuyenBay[100];
        int length;
        public void Nhap()
        {
            Them(new ChuyenBay("DaLat", "SaiGon", DateTime.Parse("2/14/2017"),true));
            Them(new ChuyenBay("DaLat", "HaNoi", DateTime.Parse("2/15/2017"), false));
            Them(new ChuyenBay("HaNoi", "Vinh", DateTime.Parse("2/15/2017"), true));
            Them(new ChuyenBay("HaNoi", "Hue", DateTime.Parse("2/15/2017"), true));
            Them(new ChuyenBay("Vinh", "DaNang", DateTime.Parse("2/12/2017"), false));
            Them(new ChuyenBay("Hue", "DaNang", DateTime.Parse("2/15/2017"), true));
        }
        public void Them(ChuyenBay p)
        {
            a[length] = new ChuyenBay();
            a[length] = p;
            length++;
        }

        public void TimThongTinChuyenBay(string s, string d)
        {
            MangChuoi dsDich = TimDanhSachDichTheoNguon(s);
            if (dsDich.length == 0) return;
            Console.WriteLine("Danh sach duong \n" + dsDich);
            if (dsDich.CoChua(d))
            {
                Console.WriteLine("Co chuyen");
                return;
            }
            for (int i= 0; i < dsDich.length; i++)
            {
                TimThongTinChuyenBay(dsDich[i], d);
            }

        }
        public void TimThongTinChuyenBay(string s, string d, string path)
        {
            MangChuoi dsDich = TimDanhSachDichTheoNguon(s);
            if (dsDich.length == 0) return;
          //  Console.WriteLine("Danh sach duong \n" + dsDich);
            if (dsDich.CoChua(d))
            {
                Console.WriteLine("Co chuyen " + path + "\\" + d);
                return;
            }
            for (int i = 0; i < dsDich.length; i++)
            {
                string tam = path + "\\" + dsDich[i];
                TimThongTinChuyenBay(dsDich[i], d, tam);
            }

        }
        public MangChuoi TimDanhSachDichTheoNguon(string nguon)
        {
            MangChuoi kq = new MangChuoi();
            for (int i = 0; i < length; i++)
                if (a[i].nguon == nguon)
                    kq.Them(a[i].dich);
            return kq;
        }
        private DanhSachChuyenBay TimChuyenBayTheoNguon(string nguon)
        {
            DanhSachChuyenBay kq = new DanhSachChuyenBay();
            for (int i = 0; i < length; i++)
                if (a[i].nguon == nguon)
                    kq.Them(a[i]);
            return kq;
        }
        enum KieuSapXep
        {
            TangTheoNguon,
            TangTheoDich,
            GiamTheoNguon,
            GiamTheoDich,
            ChieuDaiNguon
        }
        //0:Tang Theo Nguon
        int SoSanh(ChuyenBay a, ChuyenBay b, KieuSapXep k)
        {
            switch (k) {
                case KieuSapXep.TangTheoNguon:
                    return a.nguon.CompareTo(b.nguon);
                case KieuSapXep.ChieuDaiNguon:
                    return a.nguon.Length.CompareTo(b.nguon.Length);
                case KieuSapXep.GiamTheoNguon:
                    return -a.nguon.CompareTo(b.nguon);
                case KieuSapXep.TangTheoDich:
                    return a.dich.CompareTo(b.dich);
            }
            return 1;
        }
        void SapXep(KieuSapXep k)
        {
            for (int i = 0; i < length; i++)
                for (int j = i + 1; j < length; j++)
                    if (SoSanh(a[i], a[j], k)== 1)
                    {
                        var tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
        }
        public void SapXepTangTheoNguon()
        {
            SapXep(KieuSapXep.TangTheoNguon);
        }
        public void SapXepGiamTheoNguon()
        {
            SapXep(KieuSapXep.GiamTheoNguon);
        }
        public void SapXepTangTheoDich()
        {
            SapXep(KieuSapXep.TangTheoDich);
        }
        public override string ToString()
        {
            string s = "Nguon".PadRight(15,' ') + "Dich".PadRight(10,' ') + "Thoi Gian".PadRight(25, ' ')+"TinhTrang".PadRight(15, ' ');
            s += "\n=============================================================";
            for (int i = 0; i < length; i++)
                s += string.Format("\n{0})",i+1) + a[i];
            return s;

        }
    }
}
