using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PolymorphismEx  
    {
        public string z = "Basic concepts of encapsulation";
        int x =1000;
        //public int Disp(int x)
        //{
        //    //Console.WriteLine();
        //    return x;
        //}
        public int Disp()
        {
            return x;
        }
        public int Disp(int a)
        {
            return a;
        }
        public void Disp(string s)
        {
            Console.WriteLine(s); ;
        }
        public string Disp(double s)
        {
            return s.ToString();
        }
    }
    class ShadPoly
    {
        public string Disp()
        {
            return "in shadpoly";
            //Console.WriteLine("In Disp");
        }
    }
}
