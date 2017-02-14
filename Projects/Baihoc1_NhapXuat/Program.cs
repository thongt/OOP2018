using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tuoi = 10;
            float nam = 2017;
            Console.Write("Nhap vao mot so ");
            tuoi= int.Parse(Console.ReadLine());

            Console.Write("Nhap vao mot so thuc ");
            nam = float.Parse(Console.ReadLine());

            Console.WriteLine("tuoi ={0}, nam ={1}", tuoi, nam);
            
        }
    }
}
