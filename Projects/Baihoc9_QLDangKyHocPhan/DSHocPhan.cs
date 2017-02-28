using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class DSHocPhan
    {
        public List<HocPhan> ds = new List<HocPhan>();

        public HocPhan this[string maHp]
        {
            get
            {
                return ds.Find(x => x.maHP == maHp);
            }
        }

        public DSHocPhan()
        {
        }
        void Them(HocPhan s)
        {
            ds.Add(s);
        }
        public void NhapTuFile()
        {
            string line = "";
            using (StreamReader sr = new StreamReader("hocphan.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = line.Split(',');
                    Them(new HocPhan(s[0], s[1], int.Parse(s[2]), int.Parse(s[3]), int.Parse(s[4])));
                }
            }
        }
        public override string ToString()
        {
            string s = "Danh sach hoc Phan\n";int i = 1;
            foreach (var hp in ds)
                s += i++.ToString() + ")" + hp +"\n";
            return s;
        }

    }
}
