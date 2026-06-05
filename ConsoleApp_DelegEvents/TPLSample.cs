using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_DelegEvents
{
    class TPLSample
    {
        static void Display(string s) => Console.WriteLine($"I am called from {s}");
        //static void Main()
        //{
        //    //Action<string> action = (str) =>
        //    //{
        //    //    Console.WriteLine("Task started.");
        //    //    Task.Delay(1000).Wait(); // Simulate work
        //    //    Console.WriteLine($"Task completed {str}");
        //    //};
        //    //action("from action delegate");

        //    // Example: Using Task
        //    //Note : Run fn will take Action deleg as param and this Action deleg will not take any input param as above action.
        //    Task task = Task.Run(() =>
        //    {
        //        Console.WriteLine("Task started.");
        //        Task.Delay(3000).Wait();            // Simulate work
        //        Console.WriteLine("Task completed.");
        //    });
        //    Display("Main thread");

        //    // Example Task with Return Value
        //    Task<int> taskret = Task<int>.Run(() => 20 * 4 );
        //    Console.WriteLine($"Multiplication of number is : {taskret.Result}");


        //    // Example: Parallel Tasks 
        //    Parallel.For(1, 6, (i) => Console.WriteLine($"Iteration:{i} , ThreadId :{Thread.CurrentThread.ManagedThreadId}"));

        //    List<string> hardwares = new List<string> { "Display", "Mouse", "CPU", "UPS", "PenDrive" };
        //    Parallel.ForEach(hardwares,
        //        (hrdwre) => { Console.WriteLine($"Hardware Processing : {hrdwre} \t----> On ThreadId :{Thread.CurrentThread.ManagedThreadId}"); }
        //        );

        //    // ParallelOptions for setting max degree :
        //    var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
        //    Parallel.ForEach(hardwares, options,
        //        (hrdwre) => { Console.WriteLine($"Hardware Processing from ParallelOptions : {hrdwre} \t----> On ThreadId :{Thread.CurrentThread.ManagedThreadId}"); }
        //        );

        //    // Example: Task Continuation ContinueWith 
        //    Task.Run(() => { Console.WriteLine("First Task");})
        //        .ContinueWith(t => { Console.WriteLine("Continuation Task");}
        //            );


        //    Console.ReadLine();
        //}

    }
}