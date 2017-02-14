using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    class ChuyenBay
    {
        public string nguon;
        public string dich;
        public DateTime thoiGianBay;
        public bool conCho;
        public ChuyenBay() { }
        public ChuyenBay(string nguon, string dich, DateTime thoiGian, bool conCho) {
            this.nguon = nguon;
            this.dich = dich;
            this.thoiGianBay = thoiGian;
            this.conCho = conCho;
        }
        string CanhLe(string s, int rong)
        {
           
            return s.PadRight(rong, ' ');
        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}", CanhLe(nguon,10), CanhLe(dich,10), CanhLe(thoiGianBay.ToString(),25), conCho?"Co":"Khong");
        }
    }
}
