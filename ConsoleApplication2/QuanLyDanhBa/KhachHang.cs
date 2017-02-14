using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class KhachHang
    {
        public string sDT { get; set; }
        public string hoTen;
        public string Ten
        {
            get
            {
                return LayTen(hoTen);
            }
        }
        public string Duong
        {
            get
            {
                return LayDuong(diaChi).ToUpper();
            }
        }
        public string diaChi;
        public KhachHang()
        {

        }
        public KhachHang (string sdt, string hoTen, string diaChi)
        {
            this.sDT = sdt;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
        }
        static string LayTen(string s)
        {
            s = s.Trim();
            int vt1 = s.LastIndexOf(' ');
            return s.Substring(vt1, s.Length - vt1);
           
        }
        static string LayDuong(string s)
        {
            s = s.Trim();
            int vt1 = s.IndexOf(' ');
            return s.Substring(vt1, s.Length - vt1);

        }
        public override string ToString()
        {
            return string.Format("\n{0} {1} {2}", hoTen, sDT, diaChi);
        }
    }
}
