using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc10_GiaoDien
{
    //class A
    //{
    //    public static int dem = 0;
    //    public A()
    //    {
    //        dem++;
    //    }
    //}
    //class Program
    //{
    //    static int a = 10;
    //     void Main(string[] args)
    //    {
    //        A x = new A();
    //        A y = new A();
    //        Console.WriteLine(A.dem);
    //        //Console.WriteLine(a);
    //        Console.ReadKey();
    //    }
    //    void HamA()
    //    {
    //        Console.WriteLine(a);
    //    }
    //}
    interface IA
    {
        void FunA();
    }
    interface IB
    {
        void FunA();
        void FunB();
    }

    class X : IA,IB
    {
        public void FunA() {
            Console.WriteLine("Ham A");
        }

        public void FunB()
        {
            Console.WriteLine("Ham B");
        }
    }
    class SinhVien:ISoSanh
    {
        string maSV;
        Mang a = new Mang();
        public SinhVien()
        {

        }
        public SinhVien(string a)
        {
            maSV = a;
        }
        public void Test()
        {
            a.Them(new SinhVien("A"));
            a.Them(new SinhVien("B"));
            a.Them(new SinhVien("C"));
            a.Them(new SinhVien("D"));
            a.Sort(this);
            Xuat();
        }
        public void Xuat()
        {
            for (int i = 0; i < a.length; i++)
            {
                Console.WriteLine(((SinhVien)a.a[i]).maSV);
            }
        }

        public int SoSanh(object a, object b)
        {
            return -((SinhVien)a).maSV.CompareTo(((SinhVien)b).maSV);
        }
    }
    interface ISoSanh
    {
        int SoSanh(object a, object b);
    }
    class Mang
    {
        public object []a = new object[100];
        public int length = 0;
        public void Them(object x)
        {
            a[length] = new object();
            a[length] = x;
            length++;
        }
        public void Sort(ISoSanh ss)
        {
            for (int i = 0; i < length; i++)
                for (int j = i + 1; j < length; j++)
                    if (ss.SoSanh(a[i],a[j])==1)
                    {
                        var tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
        }
        public void Xuat()
        {
            for(int i=0; i<length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            //IA a = new IA();
            //a.FunA();
            //IB b = (IB)a;
            //b.FunA();
            //b.FunB();
            SinhVien a = new SinhVien();
            a.Test();




            Console.ReadKey();
        }
    }
}
