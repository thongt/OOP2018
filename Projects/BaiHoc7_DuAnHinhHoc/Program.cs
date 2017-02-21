using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiHoc7_DuAnHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //HinhHoc h = new HinhTron(4);
            //Console.WriteLine(((HinhTron)h).TinhDT());

            //HinhHoc[] a = new HinhHoc[]
            //{
            //    new HinhTron(4), new HinhVuong(2),
            //    new HinhTron(3),
            //    new HinhCN(4,5)
            //};
            ////foreach (HinhHoc h in a)
            ////{
            ////    if (h is HinhTron)
            ////        Console.WriteLine(((HinhTron)h).TinhDT());
            ////    if (h is HinhVuong)
            ////        Console.WriteLine(((HinhVuong)h).TinhDT());
            ////}
            //List<HinhHoc> a = new List<HinhHoc>
            //{
            //    new HinhTron(4), new HinhVuong(2),
            //    new HinhTron(3),
            //    new HinhCN(4,5),
            //    new HinhTron(4),
            //    new HinhTron(4)
            //};
            //a.Reverse();
            //for(int i=0; i< a.Count; i++)
            //    Console.WriteLine(a[i]);
            ////foreach (HinhHoc h in a)
            ////{

            ////        Console.WriteLine(h);

            ////}
            //a.Sort((x, y) => -x.TinhDT().CompareTo(y.TinhDT()));
            //List<HinhHoc>kq= a.FindAll(x => x.TinhDT() == a[0].TinhDT());
            //foreach (HinhHoc h in kq)
            //{

            //    Console.WriteLine(h);


            //}
            //List<string> s = new List<string>();
            //a.Add("Lap");
            //a.Add("trinh");
            //a.Add("huong");
            //a.Add("doi");
            //a.Add("tuong");
            //a.Sort();
            //foreach(string c in s)
            //    Console.WriteLine(c);

            //HinhHoc h = new HinhHoc();
            //Console.WriteLine(h.TinhDT());

            HinhHoc h1 = new HinhTron(4);
            Console.WriteLine(h1.TinhDT());


            Console.ReadKey();
        }
    }
}
