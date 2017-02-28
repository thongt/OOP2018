using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public string lop;
        public SinhVien()
        {

        }
        public SinhVien(string maSV, string hoTen, string lop)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.lop = lop;
        }
        string CanhLe(string s, int rong)
        {

            return s.PadRight(rong, ' ');
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}",CanhLe(maSV,10),CanhLe(hoTen, 15),CanhLe(lop,10));
        }

    }
    class SinhVienDH : SinhVien { }
    class SinhVienCD : SinhVien { }
}
