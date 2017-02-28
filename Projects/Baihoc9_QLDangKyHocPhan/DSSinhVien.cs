using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class DSSinhVien
    {
        public List<SinhVien> ds = new List<SinhVien>();
        public SinhVien this[string maSV]
        {
            get
            {
                return ds.Find(x => x.maSV == maSV);
            }
        }
        public DSSinhVien()
        {
        }
        void Them(SinhVien s)
        {
            ds.Add(s);
        }
        public void NhapTuFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("sinhvien.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(',');
                    Them(new SinhVien(s[0], s[1], s[2]));
                }
            }
        }
        public override string ToString()
        {
            string s = "Danh sach sinh vien\n";int i = 1;
            foreach (var sv in ds)
                s += i++.ToString() + ")" + sv +"\n";
            return s;
        }

    }
}
