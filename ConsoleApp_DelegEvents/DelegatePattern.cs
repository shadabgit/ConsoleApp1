using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Pattern
{
    delegate string fetch();
    public class MyWork
    {
        public static string fetchData()
        {
            System.Threading.Thread.Sleep(4000);
            return "Long running task update completed.";
        }
        public static void data()
        {
            Console.WriteLine("Short running.");
        }
    }
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //----------------------------------------------------EndInvoke pattern
        //    fetch obj = new fetch(MyWork.fetchData);
        //    IAsyncResult asyncResult = obj.BeginInvoke(null, null);     
        //    //MyWork.data();
        //    //Console.WriteLine(obj.EndInvoke(asyncResult));

        //    ////----------------------------------------------------Polling pattern
        //    //MyWork.data();
        //    //while (asyncResult.IsCompleted == false)
        //    //{
        //    //    System.Threading.Thread.Sleep(1000);
        //    //    Console.WriteLine("Still waiting for the 3rd party system to update..");
        //    //}
        //    //Console.WriteLine(obj.EndInvoke(asyncResult));

        //    //----------------------------------------------------WaitHandle pattern
        //    // get called to call the other function and borrowed thread runs into background which return back the output from the method it has called.

        //    MyWork.data();
        //    Console.WriteLine("\nWait..");
        //    if (asyncResult.AsyncWaitHandle.WaitOne(3000, true))
        //    {
        //        Console.WriteLine(obj.EndInvoke(asyncResult));
        //    }
        //    else
        //    {
        //        Console.WriteLine("\nNetwork Timeout...");
        //    }

        //    Console.ReadLine();

        //}
    }
}


