using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc8_SuTruuTuong
{
    class DanhSachHinhHoc
    {
        List<HinhHoc> ds = new List<HinhHoc>();
        public void Nhap()
        {
           Them(new HinhCN(3, 4));
            Them(new HinhVuong(5));
            Them(new HinhTron(6));
            Them(new HinhCN(3, 4));
            Them(new HinhVuong(5));
            Them(new HinhTron(6));
            Them(new HinhVuong(2));
            Them(new HinhVuong(2));
        }                                                                                 
        public void Them(HinhHoc p)
        {
            ds.Add(p);
        }
        public float TimMinHinhVuong()
        {
            float min = float.MaxValue;
            foreach (var h in ds)
            {
                if (h is HinhVuong && h.TinhDT() < min)
                    min = h.TinhDT();
            }
            return min;
        }
        public DanhSachHinhHoc TimDSHinhVuongMin()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = TimMinHinhVuong();
            //foreach(var h in ds)
            //{
            //    if(h is HinhVuong && h.TinhDT()==min)
            //    {
            //        kq.Them(h);
            //    }
            //}

            //return kq;
            kq.ds.AddRange(ds.FindAll(x => x is HinhVuong && x.TinhDT() == min));
            return kq;
        }
        public bool  HVCoCanhBangHCN(HinhVuong c)
        {
            foreach (var h in ds)
                if (h is HinhCN && ((HinhCN)h).canh == c.canh)
                    return true;
            return false;
        }
        public DanhSachHinhHoc TimDSHinhVuongCoCanhBangHCN()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            kq.ds.AddRange(ds.FindAll(x => x is HinhVuong 
                                       && HVCoCanhBangHCN((HinhVuong)x)));

            return kq;
        }
        public List<HinhHoc> TimDSHinhVuongCoCanhBangHCN2()
        {
           return ds.FindAll(x => x is HinhVuong
                                       && HVCoCanhBangHCN((HinhVuong)x));
        }
        public List<HinhHoc> TimDSHinhVuongTheoChieuTangDienTich()
        {
            List<HinhHoc> kq = ds.FindAll(x => x is HinhVuong);
            kq.Sort((a,b) => a.TinhDT().CompareTo(b.TinhDT())) ;
            return kq;
        }

        public override string ToString()
        {
            var s = "";
            foreach (var h in ds)
                s += h + "\n";
            return s;
        }
    }
}
