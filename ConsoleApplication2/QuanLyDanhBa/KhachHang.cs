using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class KhachHang
    {
        public string sDT;
        public string hoTen;
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
        public override string ToString()
        {
            return string.Format("\n{0} {1} {2}", hoTen, sDT, diaChi);
        }
    }
}
