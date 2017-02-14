using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuyenBay
{
    class MangChuoi
    {
        public string this[int vt]
        {
            get { return a[vt]; }
            //set { a[vt] = value; }
        }
        public string[] a = new string[100];
        public int length;
        public void Them(string p)
        {
            if (CoChua(p)) return;
            a[length] = p;
            length++;
        }
        public bool CoChua(string s)
        {
            for (int i = 0; i < length; i++)
                if (a[i] == s) return true;
            return false;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < length; i++)
                s += "\n" + a[i];
            return s;

        }
    }
}
