using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    
    public delegate void delNotify(string message);
    class CallbackDelegate
    {
        static void ShowMessage(string message) => Console.WriteLine("Callback Message: " + message);
        static void ProcessData(string data, delNotify delcallBack)
        {
            Console.WriteLine("Data processing begins.");
            System.Threading.Thread.Sleep(4000);
            delcallBack($"Invoked callback output {data}");
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Main started...");
        //    //Call ProcessData with callback function
        //    ProcessData("Sample data", ShowMessage);

        //    Console.WriteLine("Main finished.");
        //    Console.ReadLine();
        //}
    }
    /* 
     * Practicing callback........
     
    public delegate void delcall();
    class CallBackDeleg
    {
        static void dataNotification() => Console.WriteLine("callback successfully..");
        static void dataProcess(delcall delcObj) 
        {
            Console.WriteLine("data processing started");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("data processing finsihed.");
            delcObj();
        }
        static void Main()
        {
            Console.WriteLine("Main thread started");
            CallBackDeleg.dataProcess(dataNotification);
            Console.WriteLine("Main finished");
            Console.ReadLine();
        }
    }*/
}
