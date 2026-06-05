using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //internal class ThreadOne
    //{
    //    public static void Main()
    //    { 
    //        Thread th1 = new Thread(FunctionOne);   // A new thread will be created for each of the function one and two and they will execute in parallel with the main thread.
    //        Thread th2 = new Thread(FunctionTwo);
    //        th1.Start();
    //        th2.Start();

    //        Thread.Sleep(3000);
    //        Console.WriteLine("Main thread exited.");
    //    }

    //    static void FunctionOne()
    //    {
    //        for(int i =0;i<5;i++)
    //        {
    //            Console.WriteLine("Function One executing " + i +" times.");
    //            Thread.Sleep(1000); // Simulate some work
    //        }
    //    }
    //    static void FunctionTwo()
    //    {
    //        for(int i =0;i<5;i++)
    //        {
    //            Console.WriteLine("Function Two executing " + i +" times."); 
    //            Thread.Sleep(1000); // Simulate some work
    //        }
    //    }
    //}



    internal class ThreadOne
    {
        //public static void Main()
        //{
        //    Thread th1 = new Thread(FunctionOne);    
        //    th1.Start(); 
        //    th1.IsBackground = true; // Set the thread as a background thread , by default threads are foreground threads.
        //                             // Foreground threads keep the application running until they complete, while background threads do not prevent the application from exiting.
        //                             // If the main thread finishes and there are only background threads remaining, the application will exit, and any background threads still
        //                             // running will be terminated.
             
        //    Console.WriteLine("Main thread exited."); 
        //}

        static void FunctionOne()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Function One executing " + i + " times.");
            //    Thread.Sleep(1000); // Simulate some work
            //}
            Console.WriteLine("Function One executing ");
            Console.ReadLine(); 
            Console.WriteLine("Function One completed.");
        }
        
    }
}
