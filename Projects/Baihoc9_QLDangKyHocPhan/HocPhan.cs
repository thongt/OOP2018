using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class HocPhan
    {
        public string maHP;
        public string TenHP;
        public int soTC;
        public int lT;
        public int tH;

        public HocPhan()
        {

        }
        public HocPhan(string maHP, string TenHP, int soTC, int lt, int th)
        {
            this.maHP = maHP;
            this.TenHP = TenHP;
            this.soTC = soTC;
            this.lT = lt;
            this.tH = th;
        }
        string CanhLe(string s, int rong)
        {

            return s.PadRight(rong, ' ');
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}",CanhLe(maHP,10),CanhLe(TenHP, 15),soTC, lT, tH);
        }

    }
    class HocPhanDH : HocPhan { }
    class HocPhanCD : HocPhan { }
}
