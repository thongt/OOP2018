using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class DSKQDangKyHP
    {
        public List<KQDangKyHP> ds = new List<KQDangKyHP>();
        public DSKQDangKyHP()
        {
        }
        void Them(KQDangKyHP s)
        {
            ds.Add(s);
        }
        public void NhapTuFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("kqdangkyhocphan.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(',');
                    Them(new KQDangKyHP(s[0], s[1], int.Parse(s[2])));
                }
            }
        }
        public DSKQDangKyHP TimKQDKTheoMaSV(string masv)
        {
            DSKQDangKyHP kq = new DSKQDangKyHP();
            kq.ds.AddRange(ds.FindAll(x => x.maSV == masv));
            return kq;
        }
        public string Xuat(DSHocPhan dshp)
        {
            string s = "Ket qua dang ky hoc Phan\n";int i = 1;
            foreach (var kq in ds)
                s += i++.ToString() + ")" + kq.Xuat(dshp[kq.MaMH]) +"\n";
            return s;
        }

    }
}
