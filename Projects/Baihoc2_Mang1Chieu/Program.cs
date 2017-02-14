using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[100];
            //int length = 5;
            ////a[0] = 1;
            ////a[1] = 3;
            ////a[2] = 6;
            ////a[3] = 5;
            ////a[4] = 2;
            ////a[5] = 7;

            //for (int i = 0; i <= length; i++)

            //    Console.WriteLine(a[i]);


            ////Console.WriteLine(a[1]);
            ////Console.WriteLine(a[2]);
            ////Console.WriteLine(a[3]);
            ////Console.WriteLine(a[4]);
            ////Console.WriteLine(a[5]);

            //int[] a = new int[] { 1, 3, 4, 5, 6, 7 };

            //for (int i = 0; i < a.Length; i++)

            //   Console.WriteLine(a[i]);

            int[] a = new int[100];
            int length = 0;

            //Console.Write("Nhap chieu dai mang ");
            //length = int.Parse(Console.ReadLine());
            //for(int i=0; i< length; i++)
            //{
            //    Console.Write("a[{0}]=",i);
            //    a[i] = int.Parse(Console.ReadLine()); 
            //}
            //Nhap du lieu tu file
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\Tran Thong\Source\Repos\OOP2018\ConsoleApplication2\Mang1Chieu\data.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    a[length++] = int.Parse(line);
                    //Console.WriteLine(line);
                }
            }

            for (int i = 0; i < length; i++)
                Console.Write(" " + a[i]);


        }
    }
}
