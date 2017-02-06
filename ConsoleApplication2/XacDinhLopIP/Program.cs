using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhLopIP
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.Write("Nhap vao dia chi IP ");
            ////string ip = Console.ReadLine();
            //string ip = "1.10.10.10";
            //int byteDau = LayByteDauTien(ip);
            ////if(byteDau >=0 && byteDau <=127)
            ////    Console.WriteLine("{0} thuoc lop A", ip);
            ////if (byteDau >= 128 && byteDau <= 191)
            ////    Console.WriteLine("{0} thuoc lop B", ip);
            ////if (byteDau >= 192 && byteDau <= 223)
            ////    Console.WriteLine("{0} thuoc lop C", ip);
            ////if (byteDau >= 224 && byteDau <= 255)
            ////    Console.WriteLine("{0} thuoc lop D", ip);
            //string lop = "bi loi";
            //if (byteDau >= 0 && byteDau <= 127) lop = "A";
            //if (byteDau >= 128 && byteDau <= 191) lop = "B";
            //if (byteDau >= 192 && byteDau <= 223) lop = "C";
            //if (byteDau >= 224 && byteDau <= 255) lop = "D";
            //Console.WriteLine("Dia chi {0} thuoc lop {1}", ip, lop);
            XuatHoTen(" Nguyen             Ha");

        }
        static int IndexOf(string s, char c)
        {
            int vt = 0;
            foreach (char kt in s)
            {
                if (kt == c) return vt;
                vt++;
            }
            return -1;

        }

        static int LayByteDauTien(string ip)
        {
            //int vt = ip.IndexOf('.');
            int vt = IndexOf(ip,'.');
            //return int.Parse(ip.Substring(0, vt));
            string con = ip.Substring(0, vt);
            int tam = int.Parse(con);
            return tam;
            //return int.Parse(ip.Substring(0, ip.IndexOf('.')));
        }
        static void  XuatHoTen(string s)
        {
            s = s.Trim();
            int vt1 = s.IndexOf(' ');
            int vt2 = s.LastIndexOf(' ');
            Console.WriteLine(" Ho :" + s.Substring(0,vt1));
            Console.WriteLine("Ten :{0}",s.Substring(vt2, s.Length-vt2));
            Console.WriteLine(" Ho dem :" + s.Substring(vt1, vt2-vt1));
        }
    }
}
