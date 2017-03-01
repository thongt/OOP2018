using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baihoc7_KeThuav1
{
    class Cha
    {
        public string  ten;
        public Cha() { }
        public Cha(string  x) { this.ten = x.ToUpper(); }
        public void In()
        {
            Console.WriteLine("Hello {0)", ten);
        }
    }
    class Con:Cha
    {
        public string ho;
        public Con() { }
        public Con(string ho, string ten):base(ten)
        {
            this.ho = ho;
            this.ten = ten;
        }
        //public void In()
        //{
        //    base.In();
        //    Console.WriteLine("Word");
        //}
    }
}
