using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class ThreadPoolSample
    {
        static void DoWork(object state)
        {
            Console.WriteLine(state);
            Thread.Sleep(3000);  // Simulate work
            Console.WriteLine("Work done.");
        }
        //static void Main()
        //{
        //    // Queue a method to the ThreadPool
        //    ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork), "Hello from thread pool");
        //    Console.WriteLine("Main thread continues...");

        //    // Get initial available threads
        //    ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
        //    Console.WriteLine($"Initial Available Worker Threads: {workerThreads}\nInitial Available IO Threads: {completionPortThreads}");

        //    // Set maximum number of worker threads and IO threads
        //    // Note: You can only lower the max threads from the default
        //    bool isSuccess = ThreadPool.SetMaxThreads(10, 10);
        //    Console.WriteLine($"SetMaxThreads Success: {isSuccess}");

        //    ThreadPool.GetMaxThreads(out int maxWorker, out int maxIOC);
        //    Console.WriteLine($"New Max Worker Threads: {maxWorker}\nNew Max IO Threads: {maxIOC}"); 

        //    Console.ReadLine();
        //}

    }
   
}
