using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class KQDangKyHP
    {
        public string maSV;
        public string MaMH;
        public int diem;
        public HocPhan hp;
        public KQDangKyHP()
        {

        }
        public KQDangKyHP(string maSV, string MaMH, int diem)
        {
            this.maSV = maSV;
            this.MaMH = MaMH;
            this.diem = diem;
        }
        string CanhLe(string s, int rong)
        {

            return s.PadRight(rong, ' ');
        }
        public string Xuat(HocPhan hp)
        {
            this.hp = hp;
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", CanhLe(maSV, 10),CanhLe(MaMH,10),CanhLe(hp.TenHP, 15),hp.soTC, hp.lT, hp.tH, diem);
        }

    }
   
}
