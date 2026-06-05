using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ABC
    {
        public virtual void Disp()
        { Console.WriteLine("In base ABC virtual fn"); }
        public void NonVDisp()
        { Console.WriteLine("In base NonVDisp ABC"); }
    }
    class ABCChild1 : ABC
    {
        public virtual void childDisp()
        { Console.WriteLine("virtual fn of ABCChild1"); }
        public override void Disp()
        { Console.WriteLine("In ABCChild1 overriden fn"); }
    }
    class ABCChild2 : ABCChild1
    {
        public override void Disp()
        { Console.WriteLine("In ABCChild2 Disp fn"); }
        public override void childDisp()
        { Console.WriteLine("In ABCChild2 childDisp fn"); }
    }
 }
