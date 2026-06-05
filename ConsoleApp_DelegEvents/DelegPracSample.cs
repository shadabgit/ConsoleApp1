using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class DelegPracSample
    {
        delegate void voidDeleg();
        delegate void voidInputDeleg(string s);
        delegate string strDeleg();
        delegate string strInputDeleg(string s);

        //public static void Main()
        //{
        //    voidDeleg mySample1 = () => Console.WriteLine("Called from deleg returning void and taking no input..");              // Or,
        //    //voidDeleg mySample1 = new voidDeleg(() => Console.WriteLine("Called from deleg returning void and taking no input.."));
        //    mySample1();        // Or,   mySample1.Invoke();

        //    //Action<string> action = (string x) => Console.WriteLine(x);
        //    //action("action deleg called");

        //    //strInputDeleg mySample2 = (string inp) => inp;
        //    strInputDeleg mySample2 = (inp) => inp;
        //    string res = mySample2("called from deleg returning string and taking string param");
        //    Console.WriteLine(res);

        //    voidInputDeleg voidInput = (str) => Console.WriteLine($"Param value : {str}");
        //    voidInput("called from deleg returning void and taking string as input param.");

        //    Console.ReadLine();

        //}
    }
}
