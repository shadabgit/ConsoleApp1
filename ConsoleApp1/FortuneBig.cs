using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*interface IPolicy { string Policy(); }
    abstract class FortuneBig
    {
        public abstract void Display();
    }
    class OneEmp : IPolicy
    {
        string IPolicy.Policy()
        {
            return "One";
        }
    }
    class TwoEmp : IPolicy
    {
        public string Policy()
        {
            return "Two";
        }
    }

    class ThreeEmp : FortuneBig
    {
        public override void Display()
        {
            Console.WriteLine("Testing Abstract from Three");
        }
    }
    class FourEmp : FortuneBig
    {
        public override void Display()
        {
            Console.WriteLine("Testing Abstract from Four");
        }
    }
    class Accesing
    {
        //static void Main(string[] args)
        //{
        //    IPolicy ip = new OneEmp();
        //    Console.WriteLine(ip.Policy());
        //    ip = new TwoEmp();
        //    Console.WriteLine(ip.Policy());

        //    FortuneBig fort = new ThreeEmp();
        //    fort.Display();
        //    fort = new FourEmp();
        //    fort.Display();

        //    Console.ReadLine();
        //}
    }
    */

    /* abstract class IPlay 
    { 
        public abstract string Play(); 
    }
    class Cricket : IPlay
    {
        public override string Play()
        {
            return "playing Cricket";
        }
    }
    class Football : IPlay
    {
        public override string Play()
        {
            return "Playing Football";
        }
    }
     */
    interface IPlay { string Play(); }
    class Cricket : IPlay
    {
        public string Play()
        {
            return "playing Cricket";
        }
    }
    class Football : IPlay
    {
        public string Play()
        {
            return "Playing Football";
        }
    }
   
    class BAL
    {
        IPlay iplay;
        public BAL(IPlay iplay)
        {
            this.iplay = iplay;
        }
        public string OutputPlay()
        {
            return iplay.Play();
        }
        public string DisplayObjectName()
        {
            return iplay.GetType().Name;
        } 
    }
    class AccessPlay
    {
        //public static void Main()
        //{
        //    BAL bal = new BAL(new Cricket());
        //    Console.WriteLine("Associated with Class: {0}", bal.DisplayObjectName());
        //    Console.WriteLine("Output from associated type: {0}", bal.OutputPlay());
        //    Console.ReadLine();
        //}
    }
}
