using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc9_QLDangKyHocPhan
{
    class QLDangKyHocPhan
    {
        DSSinhVien dssv = new DSSinhVien();
        DSHocPhan dshp = new DSHocPhan();
        DSKQDangKyHP kqhp = new DSKQDangKyHP();
        public QLDangKyHocPhan()
        {
            dssv.NhapTuFile();
            dshp.NhapTuFile();
            kqhp.NhapTuFile();
        }
        public void Xuat()
        {
            Console.WriteLine(dssv);
            Console.WriteLine(dshp);
            Console.WriteLine(kqhp.Xuat(dshp));
        }
        //Xuat kq dang ky hoc phan cua 1 sinh vien?'
        public void XuatKQDKHPTheoMaSinhVien(string masv)
        {
            SinhVien sv = dssv[masv];
            DSKQDangKyHP ds = kqhp.TimKQDKTheoMaSV(masv);
            Console.WriteLine("Ma sinh vien:" + masv);
            Console.WriteLine("Ho ten:" + sv.hoTen);
            Console.WriteLine("Lop:" + sv.lop);
            Console.WriteLine(ds.Xuat(dshp));
            Console.Write("Tong so tin chi la {0} LT={1} TH={2}", ds.ds.Sum(x=>x.hp.soTC),ds.ds.Sum(x => x.hp.lT), ds.ds.Sum(x => x.hp.tH));

        }
        public void XuatKQDKHPTheoMaSinhVien2(string masv)
        {
            SinhVien sv = dssv[masv];
            DSKQDangKyHP ds = kqhp.TimKQDKTheoMaSV(masv);
            string template = "";
            string line = "";
            using (StreamReader sr = new StreamReader("template.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    template += line+"\n";
                }
            }

            template = template.Replace("<MASV>", masv);
            template = template.Replace("<HOTEN>", sv.hoTen);
            template = template.Replace("<LOP>", sv.lop);
            template = template.Replace("<KETQUA>", ds.Xuat(dshp));
            template = template.Replace("<SOTC>", ds.ds.Sum(x => x.hp.soTC).ToString());
            template = template.Replace("<LT>", ds.ds.Sum(x => x.hp.lT).ToString());
            template = template.Replace("<TH>", ds.ds.Sum(x => x.hp.tH).ToString());
            Console.WriteLine(template);
           

        }
        //Xoa ket qua dang ky hoc phan cua sinh vien
        public void XoaKQDKHP(string maSV, string []mahp)
        {
            foreach (var s in mahp)
                kqhp.ds.RemoveAll(x => x.maSV == maSV && x.MaMH == s);

        }

    }
}
