using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class ThreadFirst
    {
        static void DisplaySample()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Sample data from separate thread...");
        }
        static void DisplaySampleStr(object dis) => Console.WriteLine(dis.ToString());

        //static void Main()
        //{
        //    Thread t1 = new Thread(DisplaySample);                  // It will create a new thread from OS and not from THreadPool(in case of Task Parallel Library)
        //    t1.Start();                                             // Non blocking operation i.e. main thread is free to process in parallel with newly created thread from OS/Kernel

        //    Thread t2 = new Thread(() => Console.WriteLine("from second thread"));
        //    t2.Start();

        //    //ThreadStart t3 = new ThreadStart(() => Console.WriteLine("from third thread"));
        //    //Thread thread = new Thread(t3);
        //    //thread.Start();
        //    //Or,
        //    Thread thread = new Thread(new ThreadStart(() => Console.WriteLine("from third thread")));
        //    thread.Start();

        //    ParameterizedThreadStart t4 = new ParameterizedThreadStart(DisplaySampleStr);
        //    Thread threadP = new Thread(t4);
        //    threadP.Start($"Called fromo ParamThreadStart");          


        //    Console.ReadLine();
        //}

    }
}
